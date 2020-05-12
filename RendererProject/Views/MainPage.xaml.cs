
using RendererProject.Views;
using Xamarin.Forms;

namespace RendererProject.Views
{
   
    public partial class MainPage : ContentPage
    {
        private string deviceName2;

        public MainPage(string deviceName)
        {
            deviceName2 = deviceName;
            InitializeComponent();
        }

        void OnGoFirstPage(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FirstPage());
            MessagingCenter.Send<MainPage, string>(this, "entryValue", deviceName2);
        }
    }
}
