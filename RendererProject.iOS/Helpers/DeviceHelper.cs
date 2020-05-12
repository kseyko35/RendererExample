
using RendererProject.Helpers;
using RendererProject.iOS.Helpers;

[assembly:Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace RendererProject.iOS.Helpers
{
    public class DeviceHelper : IDeviceHelper
    {
       

        public string GetDeviceName()
        {
            return "Ios Interface is executing...";
        }
    }
}
