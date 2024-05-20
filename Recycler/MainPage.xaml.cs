using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Recycler
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void bt_wasteType_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new WasteTypes());
		}

		private async void bt_map_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Map());
		}

		private async void bt_codes_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Codes());
		}

    }
}
