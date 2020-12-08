using AppGallery.AppBase;
using AppGallery.XamarinForms.Paginas.Carousel;
using AppGallery.XamarinForms.Paginas.Modal;
using AppGallery.XamarinForms.Paginas.Navegacao;
using AppGallery.XamarinForms.Paginas.Tabbed;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//var pg = new NavigationPage(new Conteudo1()); //Stack
			//var pg = new PaginaModalInicio(); //Modal
			//var pg = new CarouselPage();
			//pg.Children.Add(new Pagina1());
			//pg.Children.Add(new Pagina2());
			//pg.Children.Add(new Pagina3());

			//pg.CurrentPage = pg.Children[2];

			//var pg = new Abas();

			//var pg = new MasterDetailPage();
			//pg.Master = ; //Menu
			//pg.Detail = ; //Pg

			var pg = new MenuPrincipal();
			MainPage = pg;
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
