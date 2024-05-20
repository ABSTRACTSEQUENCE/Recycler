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
			MainPage = new NavigationPage(new MainPage());
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
