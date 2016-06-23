using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

namespace DemoYoutube.Droid
{
    [Activity(Label = "DemoYoutube", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;

            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

