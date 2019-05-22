using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMvvmCrossApp1.UI.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SampleView : ContentView
	{
		public SampleView ()
		{
			InitializeComponent ();
		}
	}
}