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
	public partial class MenuLateral : MasterDetailPage
	{
		public MenuLateral()
		{
			InitializeComponent();
		}

		private void AbrirPagina1(object sender, EventArgs e)
		{
			Detail = new NavigationPage(new Menu1());
			IsPresented = false;
		}
		private void AbrirPagina2(object sender, EventArgs e)
		{
			
			Detail = new NavigationPage(new Menu2());
			IsPresented = false;
		}
		private void AbrirPagina3(object sender, EventArgs e)
		{
			Detail = new NavigationPage(new Menu3());
			IsPresented = false;
		}
	}
}