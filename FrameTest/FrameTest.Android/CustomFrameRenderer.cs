using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FrameTest.Droid;
using Xamarin.Forms;

//[assembly: ExportRenderer(typeof(Frame), typeof(CustomFrameRenderer))]
namespace FrameTest.Droid
{
    public class CustomFrameRenderer : Xamarin.Forms.Platform.Android.FrameRenderer
    {
        public CustomFrameRenderer(Context context) : base(context) { } 
    }
}