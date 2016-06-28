using System;

using UIKit;

namespace DemoYoutube.iOS.Dependencies
{
    public partial class VideoViewController3 : UIViewController
    {
        private readonly string _videoId;
        public VideoViewController3() : base("VideoViewController", null)
        {
        }

        public VideoViewController3(string videoId) : base("VideoViewController", null)
        {
            this._videoId = videoId;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            YTPlayerView playerView = new YTPlayerView();
            //playerView.Frame = new RectangleF(0, lblText.Frame.Y + lblText.Frame.Height + 10, scrollView.Frame.Width, 250);
            playerView.Init();
            playerView.LoadWithVideoId(_videoId);
            View.AddSubview(playerView);
            playerView.PlayVideo();

            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}