using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Recycler
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WasteTypes : ContentPage
	{
		PageGenerator Generator = new PageGenerator();
		public WasteTypes()
		{
			InitializeComponent();
		}
		private async  void bt_recyclable_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(Generator.GeneratePage(PageGenerator.Type.Recyclable, Navigation));
		}

		private async void bt_hazardous_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(Generator.GeneratePage(PageGenerator.Type.Hazardous, Navigation));
		}

		private async void bt_organic_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(Generator.GeneratePage(PageGenerator.Type.Organic, Navigation));
		}
		private async void bt_back_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		private async void bt_bottom_map_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new Map());
		}

		private async void bt_bottom_home_Clicked(object sender, EventArgs e)
		{
			await Navigation.PopToRootAsync();
		}
	}
}