using System;

using Android.Content;
using DemoYoutube.Droid.Dependencies;
using Xamarin.Forms;
using DemoYoutube.Common;
using System.Threading.Tasks;
using Android.Provider;
using Java.IO;
using Android.App;

[assembly: Dependency(typeof(CameraProvider))]
namespace DemoYoutube.Droid.Dependencies
{
    public class CameraProvider : ICameraProvider
    {
        private static File file;
        private static File pictureDirectory;
        private static TaskCompletionSource<CameraResult> tcs;

        public Task<CameraResult> TakePictureAsync()
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture);
            pictureDirectory = new File(Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryPictures), "Youtube");

            if(!pictureDirectory.Exists())
            {
                pictureDirectory.Mkdirs();
            }

            file = new File(pictureDirectory, string.Format("photo_{0}.jpg", Guid.NewGuid()));
            intent.PutExtra(MediaStore.ExtraOutput, Android.Net.Uri.FromFile(file));

            var activity = (Activity)Forms.Context;
            activity.StartActivityForResult(intent, 0);
            tcs = new TaskCompletionSource<CameraResult>();

            return tcs.Task;
        }

        public static void OnResult(Result resultCode)
        {
            if(resultCode == Result.Canceled)
            {
                tcs.TrySetResult(null);
            }

            if(resultCode != Result.Ok)
            {
                tcs.TrySetException(new Exception("Unexpected error!"));
            }

            CameraResult res = new CameraResult();
            res.Picture = ImageSource.FromFile(file.Path);
            res.FilePath = file.Path;
            tcs.TrySetResult(res);
        }
    }
}