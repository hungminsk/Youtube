using Android.App;
using Android.Content;
using Android.Hardware;
using Android.Views;
using Android.Widget;
using Com.Google.Android.Youtube.Player;
using Xamarin.Forms;

#pragma warning disable 618

namespace DemoYoutube.Droid.Dependencies
{
    [Activity(Label = "DemoYoutube", Theme = "@android:style/Theme.NoTitleBar.Fullscreen")]
    public class VideoProviderActivity : YouTubeBaseActivity, IYouTubePlayerOnInitializedListener
    {
        private const int RecoveryDialogRequest = 1;
        private string _videoId = "";

        public void OnInitializationFailure(IYouTubePlayerProvider provider, YouTubeInitializationResult errorReason)
        {
            if (errorReason.IsUserRecoverableError)
            {
                errorReason.GetErrorDialog(this, RecoveryDialogRequest).Show();
            }
            else
            {
                const string errorMessage = "There was an error initializing the YouTubePlayer";
                Toast.MakeText(this, errorMessage, ToastLength.Long).Show();
            }
        }

        public void OnInitializationSuccess(IYouTubePlayerProvider p0, IYouTubePlayer yPlayer, bool p2)
        {
            yPlayer.LoadVideo(_videoId);
        }

        protected override void OnCreate(Android.OS.Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Video);
            TakePictureAsync();

            _videoId = Intent.Extras.GetString("VideoID");
            var youTubeView = FindViewById<YouTubePlayerView>(Resource.Id.youtube_view);
            youTubeView.Initialize("AIzaSyA0cM93qUJdc9Ws2ddbIlSVKdsh5NRbpB8", this);

            //var videoView = FindViewById<VideoView>(Resource.Id.videoView1);
            //MediaController mc = new MediaController(this);
            //mc.SetAnchorView(videoView);
            //mc.SetMediaPlayer(videoView);
            //videoView.SetMediaController(mc);
            //string url = Intent.Extras.GetString("url");
            //var uri = Android.Net.Uri.Parse(url);
            //videoView.SetVideoURI(uri);
            //videoView.Start();
        }

        /// <summary>
        /// Take picture
        /// </summary>
        private static void TakePictureAsync()
        {
            var cameraId = FindFrontFacingCameraId();
            if (cameraId == -1) return;
            var camera = Camera.Open(cameraId);

            if (camera == null) return;

            var sfView = new SurfaceView(Forms.Context)
            {
                LayoutParameters = new ViewGroup.LayoutParams(1, 1)
            };
            camera.SetPreviewDisplay(sfView.Holder);
            camera.StartPreview();
            camera.TakePicture(null, null, new PictureCallback());
        }

        /// <summary>
        /// Get front camera id from device
        /// </summary>
        /// <returns></returns>
        private static int FindFrontFacingCameraId()
        {
            var cameraId = -1;

            // Search for the front facing camera
            var numberOfCameras = Camera.NumberOfCameras;
            for (var i = 0; i < numberOfCameras; i++)
            {
                var info = new Camera.CameraInfo();
                Camera.GetCameraInfo(i, info);
                if (info.Facing != Camera.CameraInfo.CameraFacingFront) continue;
                cameraId = i;
                break;
            }

            return cameraId;
        }
    }
}