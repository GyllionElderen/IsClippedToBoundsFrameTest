using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FrameTest.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();

            YellowElement.TranslationX += 50;
		}
	}
}