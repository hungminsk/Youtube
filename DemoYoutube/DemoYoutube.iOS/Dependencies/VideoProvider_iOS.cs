using AVFoundation;
using DemoYoutube.Common;
using DemoYoutube.iOS.Dependencies;
using Foundation;
using MediaPlayer;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(VideoProvider_iOS))]
namespace DemoYoutube.iOS.Dependencies
{
    public class VideoProvider_iOS : IVideoProvider
    {
        public void PlayVideo(string videoId)
        {
            var window = UIApplication.SharedApplication.KeyWindow;
            var viewController = window.RootViewController;
            if (viewController == null) return;
            while (viewController.PresentedViewController != null)
                viewController = viewController.PresentedViewController;
            viewController.PresentViewController(new VideoViewController(videoId), true, null);
        }
    }
}
