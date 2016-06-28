using Android.Hardware;
using Java.IO;
using System;

namespace DemoYoutube.Droid.Dependencies
{
    public class PictureCallback : Java.Lang.Object, Camera.IPictureCallback
    {
        public void OnPictureTaken(byte[] data, Camera camera)
        {
            FileOutputStream fos;

            try
            {
                File pictureDirectory = new File(Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryPictures), "Youtube");

                if (!pictureDirectory.Exists())
                {
                    pictureDirectory.Mkdirs();
                }

                File file = new File(pictureDirectory, string.Format("photo_{0}.jpg", Guid.NewGuid()));

                fos = new FileOutputStream(file);
                fos.Write(data);
                fos.Close();
            }
            catch (IOException e)
            {
                //do something about it
            }
            finally
            {
                camera.StopPreview();
                camera.Release();
            }
        }
    }
}