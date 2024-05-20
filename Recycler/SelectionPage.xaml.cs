using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Recycler
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectionPage : ContentPage
	{
		public SelectionPage(Button[]bts)
		{
			InitializeComponent();
			foreach(Button bt in bts) 
			{
				Content.Children.Add(bt);
			}
		}
	}
}