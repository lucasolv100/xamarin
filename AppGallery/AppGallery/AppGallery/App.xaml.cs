using AppGallery.XamarinForms.Paginas.Navegacao;
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

			var pg = new NavigationPage(new Conteudo1());
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
