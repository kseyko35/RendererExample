using System;
using Xamarin.Forms;

namespace RendererProject.CustomRenderers
{
    public class CustomDatePicker : DatePicker
    {
        
        public static new readonly BindableProperty TextColorProperty =
            BindableProperty.Create<CustomDatePicker, Color>(p => p.mTextColor, Color.Red);

        public Color mTextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }
    }
}
