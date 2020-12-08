using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.MenuLateral
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : ContentPage
	{
		public Menu()
		{
			InitializeComponent();
		}

		private void AbrirPagina1(object sender, EventArgs e)
		{
			MenuLateral menu = new MenuLateral();
			menu.Detail = new NavigationPage(new Menu1());
			menu.IsPresented = false;
		}
		private void AbrirPagina2(object sender, EventArgs e)
		{
			MenuLateral menu = new MenuLateral();
			menu.Detail = new NavigationPage(new Menu2());
			menu.IsPresented = false;
		}
		private void AbrirPagina3(object sender, EventArgs e)
		{
			MenuLateral menu = new MenuLateral();
			menu.Detail = new NavigationPage(new Menu3());
			menu.IsPresented = false;
		}
	}
}