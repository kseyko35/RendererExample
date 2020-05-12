
using RendererProject.CustomRenderers;
using RendererProject.iOS.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomDatePicker),typeof(CustomDatePickerRenderer))]
namespace RendererProject.iOS.CustomRenderer
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            CustomDatePicker customDatePicker =  (CustomDatePicker)Element;
            if(customDatePicker != null)
            {
                Control.Text = "You can select date ";
                Control.TextAlignment = UIKit.UITextAlignment.Center;
                
                Control.TextColor = customDatePicker.mTextColor.ToUIColor();
            }
        }

    }
}
