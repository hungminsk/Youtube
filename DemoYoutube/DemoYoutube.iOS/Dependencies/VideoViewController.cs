using AVFoundation;
using AVKit;
using Foundation;
using System;

using UIKit;

namespace DemoYoutube.iOS.Dependencies
{
    public partial class VideoViewController : AVPlayerViewController
    {
        string path;

        public VideoViewController(string path)
        {
            this.path = path;
        }

        public VideoViewController(IntPtr handle) : base (handle)
        {
        }

        public VideoViewController() : base("VideoViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Player = new AVPlayer(NSUrl.FromFilename(this.path));
            AVPlayerLayer playerLayer = AVPlayerLayer.FromPlayer(Player);
            playerLayer.Frame = View.Bounds;
            Player.Play();
        }
    }
}