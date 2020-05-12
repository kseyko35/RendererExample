using RendererProject.Helpers;
using RendererProject.Droid.Helper;

[assembly: Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace RendererProject.Droid.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetDeviceName()
        {
            return "Android Interface is executing...";
        }
    }
}
