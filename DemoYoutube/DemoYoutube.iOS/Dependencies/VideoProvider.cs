using DemoYoutube.Common;
using DemoYoutube.iOS.Dependencies;
using Foundation;
using MediaPlayer;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(VideoProvider))]
namespace DemoYoutube.iOS.Dependencies
{
    public class VideoProvider : UIView, IVideoProvider
    {
        public void PlayVideo(string path)
        {
            var moviePlayer = new MPMoviePlayerController(NSUrl.FromFilename(path));
            AddSubview(moviePlayer.View);
            moviePlayer.SetFullscreen(true, true);
            moviePlayer.Play();
        }
    }
}
