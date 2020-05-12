
using Android.Content;
using RendererProject.CustomRenderers;
using RendererProject.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomDatePicker),typeof(CustomDatePickerRenderer))]
namespace RendererProject.Droid.CustomRenderers
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        public CustomDatePickerRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            CustomDatePicker mDatePicker = (CustomDatePicker)Element;
            if(mDatePicker != null)
            {
                Control.Text = "You can Choose date...";
                Control.SetTextColor(mDatePicker.mTextColor.ToAndroid());
            }
        }
    }
}
