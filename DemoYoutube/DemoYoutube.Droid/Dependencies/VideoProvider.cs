using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DemoYoutube.Common;
using Xamarin.Forms;
using DemoYoutube.Droid.Dependencies;

[assembly: Dependency(typeof(VideoProvider))]
namespace DemoYoutube.Droid.Dependencies
{
    public class VideoProvider : IVideoProvider
    {
        public void PlayVideo(string path)
        {
            var intent = new Intent(Xamarin.Forms.Forms.Context, typeof(VideoProviderActivity));
            var bundle = new Bundle();
            bundle.PutString("url", path);
            intent.PutExtras(bundle); ;
            Xamarin.Forms.Forms.Context.StartActivity(intent);
        }
    }
}