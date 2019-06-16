using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using  Wiwii;
using Wiwii.iOS;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace Wiwii.iOS
{
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.Layer.BorderWidth = 0;
                Control.BorderStyle = UITextBorderStyle.RoundedRect;
            }
        }
    }
}