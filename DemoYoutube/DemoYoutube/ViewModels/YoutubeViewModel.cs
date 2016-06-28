using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DemoYoutube.Common;
using DemoYoutube.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace DemoYoutube.ViewModels
{
    public class YoutubeViewModel : ObservableObject
    {
        // use this link to get an api_key : https://console.developers.google.com/apis/api/youtube/
        private const string ApiKey = "AIzaSyA0cM93qUJdc9Ws2ddbIlSVKdsh5NRbpB8";
        private static string NextToken = "";

        // doc : https://developers.google.com/youtube/v3/docs/search/list#parameters 
        private readonly string apiUrlForChannel = "https://www.googleapis.com/youtube/v3/search?part=id&maxResults=20&channelId="
                                                   + "UCwq95KcdMM5BRMwYsJX4iHg"
                                                   //+ "Your_ChannelId"
                                                   + "&pageToken={0}"
                                                   + "&key="
                                                   + ApiKey;

        // doc : https://developers.google.com/apis-explorer/#p/youtube/v3/youtube.playlistItems.list
        private readonly string apiUrlForPlaylist = "https://www.googleapis.com/youtube/v3/playlistItems?part=contentDetails&maxResults=20&playlistId="
                                                    + "PLpbcUe4chE7-uGCH1S0-qeuCWOMa2Tmam"
                                                    //+ "Your_PlaylistId"
                                                    + "&key="
                                                    + ApiKey;

        // doc : https://developers.google.com/apis-explorer/#p/youtube/v3/youtube.search.list
        private readonly string apiUrlForVideosDetails = "https://www.googleapis.com/youtube/v3/videos?part=snippet,statistics&id="
                                                         + "{0}"
                                                         //+ "0ce22qhacyo,j8GU5hG-34I,_0aQJHoI1e8"
                                                         //+ "Your_Videos_Id"
                                                         + "&key="
                                                         + ApiKey;

        private string SearchText { get; set; }
        private ObservableCollection<YoutubeItem> _youtubeItem;

        public YoutubeViewModel()
        {
            Init();
        }

        public YoutubeViewModel(string searchText)
        {
            this.SearchText = searchText;

            Init();
        }

        private void Init()
        {
            LoadVideosCommand = new Command(LoadYoutubeItems);

            LoadYoutubeItems();
        }

        public ObservableCollection<YoutubeItem> YoutubeItems => _youtubeItem ?? (_youtubeItem = new ObservableCollection<YoutubeItem>());

        public ICommand LoadVideosCommand { get; set; }


        private void LoadYoutubeItems()
        {
            InitDataAsync();
        }

        private async void InitDataAsync()
        {
            await GetVideoIdsFromChannelAsync();
        }

        private async Task<List<string>> GetVideoIdsFromChannelAsync()
        {
            var httpClient = new HttpClient();
            var url = string.Format(apiUrlForChannel, NextToken);
            url = (string.IsNullOrEmpty(SearchText) ? url : $"{url}&q={SearchText}");

            var json = await httpClient.GetStringAsync(url);

            var videoIds = new List<string>();

            try
            {
                JObject response = JsonConvert.DeserializeObject<dynamic>(json);

                var items = response.Value<JArray>("items");

                var token = response.Value<string>("nextPageToken");

                if (token != null && token != NextToken)
                    NextToken = token;
                else
                {
                    return null;
                }

                foreach (var item in items)
                {
                    videoIds.Add(item.Value<JObject>("id")?.Value<string>("videoId"));
                }

                var Videos = await GetVideosDetailsAsync(videoIds);
                foreach (var video in Videos)
                {
                    YoutubeItems.Add(video);
                }
            }
            catch (Exception ex)
            {
                // ignored
            }

            return videoIds;
        }

        private async Task<List<string>> GetVideoIdsFromPlaylistAsync()
        {
            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(apiUrlForPlaylist);

            var videoIds = new List<string>();

            try
            {
                JObject response = JsonConvert.DeserializeObject<dynamic>(json);

                var items = response.Value<JArray>("items");

                foreach (var item in items)
                {
                    videoIds.Add(item.Value<JObject>("contentDetails")?.Value<string>("videoId"));
                }

                var Items = await GetVideosDetailsAsync(videoIds);
                foreach (var item in Items)
                {
                    YoutubeItems.Add(item);
                }
            }
            catch (Exception)
            {
            }

            return videoIds;
        }

        private async Task<List<YoutubeItem>> GetVideosDetailsAsync(List<string> videoIds)
        {
            var videoIdsString = videoIds.Aggregate("", (current, s) => current + (s + ","));

            var httpClient = new HttpClient();

            var json = await httpClient.GetStringAsync(string.Format(apiUrlForVideosDetails, videoIdsString));

            var youtubeItems = new List<YoutubeItem>();

            try
            {
                JObject response = JsonConvert.DeserializeObject<dynamic>(json);

                var items = response.Value<JArray>("items");

                foreach (var item in items)
                {
                    var snippet = item.Value<JObject>("snippet");
                    var statistics = item.Value<JObject>("statistics");

                    var youtubeItem = new YoutubeItem
                    {
                        Title = snippet.Value<string>("title"),
                        Description = snippet.Value<string>("description"),
                        ChannelTitle = snippet.Value<string>("channelTitle"),
                        PublishedAt = snippet.Value<DateTime>("publishedAt"),
                        VideoId = item?.Value<string>("id"),
                        DefaultThumbnailUrl =
                            snippet?.Value<JObject>("thumbnails")?.Value<JObject>("default")?.Value<string>("url"),
                        MediumThumbnailUrl =
                            snippet?.Value<JObject>("thumbnails")?.Value<JObject>("medium")?.Value<string>("url"),
                        HighThumbnailUrl =
                            snippet?.Value<JObject>("thumbnails")?.Value<JObject>("high")?.Value<string>("url"),
                        StandardThumbnailUrl =
                            snippet?.Value<JObject>("thumbnails")?.Value<JObject>("standard")?.Value<string>("url"),
                        MaxResThumbnailUrl =
                            snippet?.Value<JObject>("thumbnails")?.Value<JObject>("maxres")?.Value<string>("url"),
                        ViewCount = statistics?.Value<int>("viewCount"),
                        LikeCount = statistics?.Value<int>("likeCount"),
                        DislikeCount = statistics?.Value<int>("dislikeCount"),
                        FavoriteCount = statistics?.Value<int>("favoriteCount"),
                        CommentCount = statistics?.Value<int>("commentCount"),
                        Tags = (from tag in snippet?.Value<JArray>("tags") select tag.ToString())?.ToList()
                    };

                    youtubeItems.Add(youtubeItem);
                }

                return youtubeItems;
            }
            catch (Exception)
            {
                return youtubeItems;
            }
        }
    }
}
