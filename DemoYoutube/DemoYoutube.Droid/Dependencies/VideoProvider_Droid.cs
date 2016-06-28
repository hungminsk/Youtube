using Android.Content;
using Android.OS;
using DemoYoutube.Common;
using DemoYoutube.Droid.Dependencies;
using Xamarin.Forms;

[assembly: Dependency(typeof(VideoProvider_Droid))]

namespace DemoYoutube.Droid.Dependencies
{
    public class VideoProvider_Droid : IVideoProvider
    {
        public void PlayVideo(string videoId)
        {
            var intent = new Intent(Forms.Context, typeof(VideoProviderActivity));
            var bundle = new Bundle();
            bundle.PutString("VideoID", videoId);
            intent.PutExtras(bundle);
            Forms.Context.StartActivity(intent);
        }
    }
}