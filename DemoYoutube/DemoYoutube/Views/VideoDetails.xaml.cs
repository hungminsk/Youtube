using Android.App;
using Android.Widget;
using DemoYoutube.Common;
using DemoYoutube.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using YoutubeExtractor;

namespace DemoYoutube.Views
{
    public partial class VideoDetails : ContentPage
    {
        public VideoDetails()
        {
            InitializeComponent();
            //Creating TapGestureRecognizers  
            var tapImage = new TapGestureRecognizer();
            //Binding events  
            tapImage.Tapped += tapImage_Tapped;
            //Associating tap events to the image buttons  
            btnPlay.GestureRecognizers.Add(tapImage);
        }

        void tapImage_Tapped(object sender, EventArgs e)
        {
            
            // Take Picture with show camera app
            //DependencyService.Get<ICameraProvider>().TakePictureAsync();
            var item = BindingContext as YoutubeItem;

            //IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls($"https://www.youtube.com/watch?v={item.VideoId}");
            //VideoInfo video = videoInfos.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);

            //if (video.RequiresDecryption)
            //{
            //    DownloadUrlResolver.DecryptDownloadUrl(video);
            //}

            //DependencyService.Get<ICameraProvider>().TakePictureAsync();
            // Play video.
            DependencyService.Get<IVideoProvider>().PlayVideo(item.VideoId);

        }
    }
}
