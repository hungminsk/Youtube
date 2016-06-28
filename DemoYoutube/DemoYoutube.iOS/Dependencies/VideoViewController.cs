using AssetsLibrary;
using AVFoundation;
using AVKit;
using CoreImage;
using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UIKit;
using YoutubeExtractor;

namespace DemoYoutube.iOS.Dependencies
{
    public partial class VideoViewController : AVPlayerViewController
    {
        private readonly string _videoId;

        public VideoViewController(string videoId)
        {
            _videoId = videoId;
        }

        public VideoViewController(IntPtr handle) : base(handle)
        {
        }

        public VideoViewController() : base("VideoViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            TakePicture();

            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls($"https://www.youtube.com/watch?v={_videoId}");
            VideoInfo video = videoInfos.First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 360);

            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            Player = new AVPlayer(NSUrl.FromFilename(video.DownloadUrl));
            var playerLayer = AVPlayerLayer.FromPlayer(Player);
            playerLayer.Frame = View.Bounds;
            Player.Play();
        }

        private void TakePicture()
        {
            var session = new AVCaptureSession();
            var camera = AVCaptureDevice.DefaultDeviceWithMediaType(AVMediaType.Video);
            var input = AVCaptureDeviceInput.FromDevice(camera);
            session.AddInput(input);

            var output = new AVCaptureStillImageOutput();
            var dict = new NSMutableDictionary();
            dict[AVVideo.CodecKey] = new NSNumber((int)AVVideoCodec.JPEG);
            session.AddOutput(output);

            //Your preview view
            var previewLayer = new AVCaptureVideoPreviewLayer(session);
            //var view = new MyPreviewView(previewLayer);
            previewLayer.Frame = View.Bounds;

            session.StartRunning();
            var connection = output.Connections[0];
            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1000);
                    CaptureImageWithMetadata(output, connection);
                }
            });
        }

        private async void CaptureImageWithMetadata(AVCaptureStillImageOutput output, AVCaptureConnection connection)
        {
            var sampleBuffer = await output.CaptureStillImageTaskAsync(connection);
            var imageData = AVCaptureStillImageOutput.JpegStillToNSData(sampleBuffer);

            var image = CIImage.FromData(imageData);
            var metadata = image.Properties.Dictionary.MutableCopy() as NSMutableDictionary;

            //...manipulate metadata here...

            ALAssetsLibrary library = new ALAssetsLibrary();
            library.WriteImageToSavedPhotosAlbum(imageData, metadata, (assetUrl, error) =>
            {
                if (error == null)
                {
                    Console.WriteLine("assetUrl:" + assetUrl);
                }
                else
                {
                    Console.WriteLine(error);
                }
            });
        }
    }
}