using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Recycler
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Map : ContentPage
	{
		bool FoodMode = false;
		bool GardenMode = false;
		public enum MapMode
		{
			None,
			Paper,
			Metal,
			Glass,
			Plastic,
			Battaries,
			Chem,
			Pharma,
			Electro,
			Food,
			Garden,
			Animal
		};
		List<Pin> PlasticPins = new List<Pin>()
		{
			new Pin()
			{
				Label = "Экодом Разделяю сердцем",
				Address = "бул. Гагарина, 65/1",
				Position = new Position(58.005224, 56.289051),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Вторпроект",
				Address = "Рязанская ул., 101",
				Position= new Position(57.970401, 56.180906),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Эконис",
				Address = "ул. Куйбышева, 128А",
				Position= new Position(57.957415, 56.248191),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Вторая жизнь",
				Address = "Ижевская ул., 29А",
				Position= new Position(57.984108, 56.275414),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Аверспак",
				Address = "ул. Клары Цеткин, 14",
				Position = new Position(57.987635, 56.240165),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "ТКО-Прикамье",
				Address = "1-я Бахаревская ул., 53, корп. 4",
				Position = new Position(57.952086, 56.238480),
				Type = PinType.Place
			},
		};
		List<Pin> PaperPins = new List<Pin>()
		{
			new Pin()
			{
				Label = "Аверспак",
				Address = "ул. Клары Цеткин, 14",
				Position = new Position(57.987635, 56.240165),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Вторая жизнь",
				Address = "Ижевская ул., 29А",
				Position = new Position(57.984108, 56.275414),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Перммакулатура жизнь",
				Address = "ул. Дзержинского, 53",
				Position = new Position(58.006800, 56.162283),
				Type = PinType.Place
			}
		};
		List<Pin> MetalPins = new List<Pin>()
		{
			new Pin()
			{
				Label = "А-кат Приём катализаторов",
				Address = "ул. Яблочкова, 9",
				Position = new Position(57.970391, 56.231662),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Лига",
				Address = "Хлебозаводская ул., 19А/3",
				Position = new Position(57.970619, 56.254718),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Алмеко",
				Address = "ул. Лодыгина, 9",
				Position = new Position(57.966985, 56.237903),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Метапром",
				Address = "ул. Героев Хасана, 66/1",
				Position = new Position(57.964009, 56.255998),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Танталмет",
				Address = "ул. Героев Хасана, 74, корп. 2",
				Position = new Position(57.960768, 56.264309),
				Type = PinType.Place
			},
		};
		List<Pin> GlassPins = new List<Pin>()
		{
			new Pin()
			{
				Label = "Прием стеклотары",
				Address = "Фоминская ул., 53",
				Position = new Position(58.008241, 56.070401),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Пункт приема стеклотары",
				Address = "ул. Писарева, 13",
				Position = new Position(58.105759, 56.304768),
				Type = PinType.Place
			}
		};
		List<Pin> BattariesPins = new List<Pin>()
		{
			new Pin()
			{
				Label = "Пункт приема батареек",
				Address = "Витимская ул., 17А",
				Position = new Position(58.040671, 55.893869),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Пункт приема батареек",
				Address = "трасса Пермь – Краснокамск, 71/1",
				Position = new Position(58.053403, 55.852358),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Пункт приема батареек",
				Address = "Витимская ул., 17А",
				Position = new Position(58.048354, 56.062356),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Пункт приема батареек",
				Address = "Подлесная ул., 43Б",
				Position = new Position(57.996483, 56.166198),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Пункт приема батареек",
				Address = "Братская ул., 137",
				Position = new Position(57.976005, 56.315113),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Пункт приема батареек",
				Address = "ул. Писарева, 2В",
				Position = new Position(58.107913, 56.318169),
				Type = PinType.Place
			},
		};
		List<Pin> ChemPins = new List<Pin>()
		{
			new Pin()
			{
				Label = "Промотходы",
				Address = "Кронштадтская ул., 39А",
				Position = new Position(57.996946, 56.204569),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Вторпроект",
				Address = "Рязанская ул., 101",
				Position = new Position(57.970401, 56.180906),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "НПП Эруто",
				Address = "ул. Солдатова, 44",
				Position = new Position(57.975814, 56.243235),
				Type = PinType.Place
			},
		};
		List<Pin> PharmaPins = new List<Pin>()
		{
			new Pin()
			{
				Label = "НПП Эруто",
				Address = "ул. Солдатова, 44",
				Position = new Position(57.975814, 56.243235),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Вторпроект",
				Address = "Рязанская ул., 101",
				Position = new Position(57.970401, 56.180906),
				Type = PinType.Place
			},
		};
		List<Pin> ElectroPins = new List<Pin>()
		{
			new Pin()
			{
				Label = "Уфпг",
				Address = "ш. Космонавтов, 111Б, корп. 45",
				Position = new Position(57.990518, 56.210428),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "АО Про Тко",
				Address = "ул. Чкалова, 9Д",
				Position = new Position(57.984629, 56.263089),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Экологические Системы",
				Address = "Хлебозаводская ул., 19А/2",
				Position = new Position(57.970426, 56.254553),
				Type = PinType.Place
			},
		};
		List<Pin> FoodPins = new List<Pin>()
		{
			new Pin()
			{
				Label = "Уфпг",
				Address = "ш. Космонавтов, 111Б, корп. 45",
				Position = new Position(57.990518, 56.210428),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Вторпроект",
				Address = "Рязанская ул., 101",
				Position= new Position(57.970401, 56.180906),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "НПП Эруто",
				Address = "ул. Солдатова, 44",
				Position = new Position(57.975814, 56.243235),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "ТКО-Прикамье",
				Address = "1-я Бахаревская ул., 53, корп. 4",
				Position = new Position(57.952086, 56.238480),
				Type = PinType.Place
			},
		};
		List<Pin> GardenPins = new List<Pin>()
		{
			new Pin()
			{
				Label = "Вторпроект",
				Address = "Рязанская ул., 101",
				Position= new Position(57.970401, 56.180906),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "НПП Эруто",
				Address = "ул. Солдатова, 44",
				Position = new Position(57.975814, 56.243235),
				Type = PinType.Place
			},
		};
		List<Pin> AnimalPins = new List<Pin>()
		{
			new Pin()
			{
				Label = "НПП Эруто",
				Address = "ул. Солдатова, 44",
				Position = new Position(57.975814, 56.243235),
				Type = PinType.Place
			},
			new Pin()
			{
				Label = "Склад",
				Address = "Сахалинская ул., 2",
				Position = new Position(57.975680, 56.316610),
				Type = PinType.Place
			},
		};
		/*
		 List<Pin> Pins = new List<Pin>()
		{
			new Pin()
			{
				Label = "Название организации",
				Address = "Адрес",
				Position = new Position(57.987635, 56.240165), //Координаты
				Type = PinType.Place
			},
	};
		*/
		public Map ()
		{
			InitializeComponent ();
			//map = new Xamarin.Forms.Maps.Map(new MapSpan(new Position(58.010455, 56.229443), 58.010455, 56.229443));
		}
		public Map(MapMode mode)
		{
			InitializeComponent();
			switch (mode)
			{
				case MapMode.Plastic:{ foreach (Pin pin in PlasticPins) map.Pins.Add(pin); break; }
				case MapMode.Paper: { foreach(Pin pin in PaperPins) map.Pins.Add(pin); break; }
				case MapMode.Food: { foreach (Pin pin in FoodPins) map.Pins.Add(pin); break; }
				case MapMode.Chem: { foreach (Pin pin in ChemPins) map.Pins.Add(pin); break; }
				case MapMode.Pharma: { foreach (Pin pin in PharmaPins) map.Pins.Add(pin); break; }
				case MapMode.Electro: { foreach (Pin pin in ElectroPins) map.Pins.Add(pin); break; }
				case MapMode.Battaries: { foreach (Pin pin in BattariesPins) map.Pins.Add(pin); break; }
				case MapMode.Garden: { foreach (Pin pin in GardenPins) map.Pins.Add(pin); break; }
				case MapMode.Animal: { foreach (Pin pin in AnimalPins) map.Pins.Add(pin); break; }
				case MapMode.Metal: { foreach (Pin pin in MetalPins) map.Pins.Add(pin); break; }
				case MapMode.Glass: { foreach (Pin pin in GlassPins) map.Pins.Add(pin); break; }
			}
		}

		private void bt_garden_Clicked(object sender, EventArgs e)
		{
			if (!GardenMode)
			{
				foreach (Pin pin in GardenPins) map.Pins.Add(pin);
				GardenMode = true;
			}
			else
			{
				GardenMode = false;
				foreach (Pin pin in GardenPins) map.Pins.Remove(pin);
			} 
		}

		private void bt_organic_Clicked(object sender, EventArgs e)
		{
			if (!FoodMode)
			{
				foreach (Pin pin in FoodPins) map.Pins.Add(pin);
				FoodMode = true;
			}
			else
			{
				foreach (Pin pin in FoodPins) map.Pins.Remove(pin);
				FoodMode = false;
			}
		}
	}
}