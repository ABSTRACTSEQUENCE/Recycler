using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace Recycler
{
	public partial class App : Application
	{
		public const string AppName = "Название приложения";
		public App()
		{
			InitializeComponent();
			NavigationPage page = new NavigationPage(new MainPage());
			MainPage = page;
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}

	}
}
