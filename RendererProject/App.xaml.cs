using System;
using RendererProject.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RendererProject
{
    public partial class App : Application
    {
        public App()
        {
            string deviceName = DependencyService.Get<IDeviceHelper>().GetDeviceName();
            InitializeComponent();
           
            MainPage = new NavigationPage(new Views.MainPage(deviceName));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
