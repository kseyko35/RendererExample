
using RendererProject.CustomRenderers;
using Xamarin.Forms;

namespace RendererProject.Views
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();

            CustomEntry mEntry = new CustomEntry();
            Entry mEntryTwo = new Entry { Placeholder = "Without renderer" };
            Label mLabel = new Label();
            CustomDatePicker datePicker = new CustomDatePicker {
                mTextColor = Color.DarkCyan
            };
            CustomDatePicker datePicker1 = new CustomDatePicker();
            
            




            MessagingCenter.Subscribe<MainPage, string>(this, "entryValue", (sender, value) => {

                mLabel.Text = value;
                mLabel.FontSize = 25;
                mLabel.VerticalOptions = LayoutOptions.Center;
                mLabel.HorizontalOptions = LayoutOptions.Center;
               

                MessagingCenter.Unsubscribe<MainPage, string>(this, "entryValue");
            });

            Content = new StackLayout
            {
            
                Children =
                {
                    mEntry,
                    mLabel,
                    mEntryTwo,
                    datePicker,
                    datePicker1
                }
            };

        }
    }
}
