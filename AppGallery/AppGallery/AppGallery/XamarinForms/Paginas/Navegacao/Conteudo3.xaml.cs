using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.Navegacao
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Conteudo3 : ContentPage
	{
		public Conteudo3()
		{
			InitializeComponent();
		}

		private void VoltarAsync(object sender, EventArgs e)
		{
			//var primeira = Navigation.NavigationStack.First();
			Navigation.PopAsync();
		}

		protected override bool OnBackButtonPressed()
		{
			return true;
		}

		private void AddPagina(object sender, EventArgs e)
		{
			Navigation.InsertPageBefore(new PaginaInserida(), Navigation.NavigationStack[0]);
		}

		private void RemoverPagina(object sender, EventArgs e)
		{
			Navigation.RemovePage(Navigation.NavigationStack[0]);
		}

		private void VoltarInicio(object sender, EventArgs e)
		{
			Navigation.PopToRootAsync();
		}
	}
}