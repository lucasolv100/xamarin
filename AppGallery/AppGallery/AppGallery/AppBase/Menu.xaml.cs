using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.AppBase
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPrincipal : MasterDetailPage
	{
		public MenuPrincipal()
		{
			InitializeComponent();
		}

		private void AbrirContentPage(object sender, EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginasConteudo.Conteudo01();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		private void AbrirNavigationPage(object sender, EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.Navegacao.Conteudo1());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		private void AbrirCarouselPage(object sender, EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail =new XamarinForms.Paginas.Carousel.Carousel();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		private void AbrirTabbedPage(object sender, EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.Tabbed.Abas();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		private void AbrirMasterDetailPage(object sender, EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.MenuLateral.MenuLateral();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		private void AbrirModal(object sender, EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.Modal.PaginaModal();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}
	}
}