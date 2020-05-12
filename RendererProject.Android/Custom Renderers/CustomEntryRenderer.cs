using Android.Content;
using RendererProject.CustomRenderers;
using RendererProject.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace RendererProject.Droid.CustomRenderers
{

    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.BlanchedAlmond);
                Control.SetTextColor(Android.Graphics.Color.BurlyWood);

               
                Control.FocusChange += (sender, ee) => {
                    bool hasFocus = ee.HasFocus;
                    if (hasFocus)
                    {
                        Control.SetBackgroundColor(Android.Graphics.Color.Blue);
                    }
                    else
                    {
                        Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
                    }
                };

                 
            }
        }
    }
}
