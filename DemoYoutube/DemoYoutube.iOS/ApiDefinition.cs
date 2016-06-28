using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
using UIKit;
using ObjCRuntime;

namespace DemoYoutube.iOS
{
    [Model, BaseType(typeof(NSObject))]
    public partial interface YTPlayerViewDelegate
    {

        [Export("playerViewDidBecomeReady:")]
        void PlayerViewDidBecomeReady(YTPlayerView playerView);

        [Export("playerView:didChangeToState:")]
        void DidChangeToState(YTPlayerView playerView, YTPlayerState state);

        [Export("playerView:didChangeToQuality:")]
        void DidChangeToQuality(YTPlayerView playerView, YTPlaybackQuality quality);

        [Export("playerView:receivedError:")]
        void ReceivedError(YTPlayerView playerView, YTPlayerError error);
    }

    [BaseType(typeof(UIWebView))]
    public partial interface YTPlayerView
    {

        [Export("webView", ArgumentSemantic.Retain)]
        UIWebView WebView { get; }

        [Export("delegate", ArgumentSemantic.Assign)]
        YTPlayerViewDelegate Delegate { get; set; }

        [Export("loadWithVideoId:")]
        bool LoadWithVideoId(string videoId);

        [Export("loadWithPlaylistId:")]
        bool LoadWithPlaylistId(string playlistId);

        [Export("loadWithVideoId:playerVars:")]
        bool LoadWithVideoId(string videoId, NSDictionary playerVars);

        [Export("loadWithPlaylistId:playerVars:")]
        bool LoadWithPlaylistId(string playlistId, NSDictionary playerVars);

        [Export("playVideo")]
        void PlayVideo();

        [Export("pauseVideo")]
        void PauseVideo();

        [Export("stopVideo")]
        void StopVideo();

        [Export("seekToSeconds:allowSeekAhead:")]
        void SeekToSeconds(float seekToSeconds, bool allowSeekAhead);

        [Export("clearVideo")]
        void ClearVideo();

        [Export("cueVideoById:startSeconds:suggestedQuality:")]
        void CueVideoById(string videoId, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("cueVideoById:startSeconds:endSeconds:suggestedQuality:")]
        void CueVideoById(string videoId, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality);

        [Export("loadVideoById:startSeconds:suggestedQuality:")]
        void LoadVideoById(string videoId, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("loadVideoById:startSeconds:endSeconds:suggestedQuality:")]
        void LoadVideoById(string videoId, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality);

        [Export("cueVideoByURL:startSeconds:suggestedQuality:")]
        void CueVideoByURL(string videoURL, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("cueVideoByURL:startSeconds:endSeconds:suggestedQuality:")]
        void CueVideoByURL(string videoURL, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality);

        [Export("loadVideoByURL:startSeconds:suggestedQuality:")]
        void LoadVideoByURL(string videoURL, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("loadVideoByURL:startSeconds:endSeconds:suggestedQuality:")]
        void LoadVideoByURL(string videoURL, float startSeconds, float endSeconds, YTPlaybackQuality suggestedQuality);

        [Export("cuePlaylistByPlaylistId:index:startSeconds:suggestedQuality:")]
        void CuePlaylistByPlaylistId(string playlistId, int index, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("cuePlaylistByVideos:index:startSeconds:suggestedQuality:")]
        void CuePlaylistByVideos(string[] videoIds, int index, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("loadPlaylistByPlaylistId:index:startSeconds:suggestedQuality:")]
        void LoadPlaylistByPlaylistId(string playlistId, int index, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("loadPlaylistByVideos:index:startSeconds:suggestedQuality:")]
        void LoadPlaylistByVideos(string[] videoIds, int index, float startSeconds, YTPlaybackQuality suggestedQuality);

        [Export("nextVideo")]
        void NextVideo();

        [Export("previousVideo")]
        void PreviousVideo();

        [Export("playVideoAt:")]
        void PlayVideoAt(int index);

        [Export("playbackRate")]
        float PlaybackRate { get; set; }

        [Export("availablePlaybackRates")]
        string[] AvailablePlaybackRates { get; }

        [Export("loop")]
        bool Loop { set; }

        [Export("shuffle")]
        bool Shuffle { set; }

        [Export("videoLoadedFraction")]
        float VideoLoadedFraction { get; }

        [Export("playerState")]
        YTPlayerState PlayerState { get; }

        [Export("currentTime")]
        float CurrentTime { get; }

        [Export("playbackQuality")]
        YTPlaybackQuality PlaybackQuality { get; set; }

        [Export("availableQualityLevels")]
        string[] AvailableQualityLevels { get; }

        [Export("duration")]
        int Duration { get; }

        [Export("videoUrl")]
        NSUrl VideoUrl { get; }

        [Export("videoEmbedCode")]
        string VideoEmbedCode { get; }

        [Export("playlist")]
        string[] Playlist { get; }

        [Export("playlistIndex")]
        int PlaylistIndex { get; }
    }
}
