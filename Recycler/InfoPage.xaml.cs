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
	public partial class InfoPage : ContentPage
	{
		public InfoPage(string MainHeader, Article[] articles, Map.MapMode mapMode)
		{
			InitializeComponent ();
			this.MainHeader.Text = MainHeader;
			foreach (Article article in articles)
			{
				Label header = new Label()
				{
					Text = article.Header
				};
				foreach (string s in article.Elements)
				{
					Label l = new Label() { Text = s};
					if(article.Options == Article.HorizontalOptions.Left)
					{
						l.Style = Application.Current.Resources["text_l"] as Style;
						header.HorizontalTextAlignment = TextAlignment.Start;
					}
					else if(article.Options == Article.HorizontalOptions.Right)
					{
						l.Style = Application.Current.Resources["text_r"] as Style;
						header.HorizontalTextAlignment = TextAlignment.End;
					}
					
					Articles.Children.Add(header);
					Articles.Children.Add(l);
					if (article.button != null)
						Articles.Children.Add(article.button);
				}
			}
			Button bt_map = new Button()
			{
				Style = Application.Current.Resources["bt_gotoMap"] as Style
			};
			bt_map.Clicked += (e, a) => { Navigation.PushAsync(new Map(mapMode)); };
			if (mapMode != Map.MapMode.None) { Articles.Children.Add(new Label() { Text = "Куда сдавать в городе Пермь?",HorizontalTextAlignment = TextAlignment.Center}); Articles.Children.Add(bt_map); }
		}
		public InfoPage()
		{
			InitializeComponent();
		}
	}
}