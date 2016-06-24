using Android.App;
using Android.Content;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace DemoYoutube.Droid.Dependencies
{
    [Activity(Label = "DemoYoutube", Theme = "@android:style/Theme.NoTitleBar.Fullscreen")]
    public class VideoProviderActivity : Activity
    {
        protected override void OnCreate(Android.OS.Bundle bundle)
        {
            SetContentView(Resource.Layout.Video);

            base.OnCreate(bundle);

            var videoView = FindViewById<VideoView>(Resource.Id.videoView1);
            MediaController mc = new MediaController(this);
            mc.SetAnchorView(videoView);
            mc.SetMediaPlayer(videoView);
            videoView.SetMediaController(mc);
            string url = Intent.Extras.GetString("url");
            var uri = Android.Net.Uri.Parse(url);
            videoView.SetVideoURI(uri);
            videoView.Start();
        }
    }
}