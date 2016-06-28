using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoYoutube.Common
{
    public interface ICameraProvider
    {
        Task<bool> TakePictureAsync();
    }
}
