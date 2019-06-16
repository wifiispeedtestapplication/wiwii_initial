using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Content;
using Wiwii;
using Wiwii.Droid;
using Android.Graphics.Drawables;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace Wiwii.Droid
{
    class MyEntryRenderer : EntryRenderer
    {
        public MyEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
               
            }
        }
    }
}

