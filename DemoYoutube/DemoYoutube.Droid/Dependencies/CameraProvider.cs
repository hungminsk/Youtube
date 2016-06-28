using DemoYoutube.Droid.Dependencies;
using Xamarin.Forms;
using DemoYoutube.Common;
using System.Threading.Tasks;
using Android.Hardware;
using Android.Views;

[assembly: Dependency(typeof(CameraProvider))]
namespace DemoYoutube.Droid.Dependencies
{
    public class CameraProvider : ICameraProvider
    {
        public Task<bool> TakePictureAsync()
        {
            Camera camera = Camera.Open(FindFrontFacingCameraID());

            if (camera != null)
            {
                SurfaceView sfview = new SurfaceView(Forms.Context);
                sfview.LayoutParameters = new ViewGroup.LayoutParams(1, 1);
                camera.SetPreviewDisplay(sfview.Holder);
                camera.StartPreview();
                camera.TakePicture(null, null, new PictureCallback());
                return new Task<bool>(() => true);
            }
            else
            {
                return new Task<bool>(() => false);
            }
        }

        private int FindFrontFacingCameraID()
        {
            int cameraId = -1;
            // Search for the front facing camera
            int numberOfCameras = Camera.NumberOfCameras;
            for (int i = 0; i < numberOfCameras; i++)
            {
                Camera.CameraInfo info = new Camera.CameraInfo();
                Camera.GetCameraInfo(i, info);
                if (info.Facing == Camera.CameraInfo.CameraFacingFront)
                {
                    cameraId = i;
                    break;
                }
            }
            return cameraId;
        }
    }
}