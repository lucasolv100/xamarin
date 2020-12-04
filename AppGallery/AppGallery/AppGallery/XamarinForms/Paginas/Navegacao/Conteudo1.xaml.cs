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
	public partial class Conteudo1 : ContentPage
	{
		public Conteudo1()
		{
			InitializeComponent();
		}

		private void AbrirPagina02(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Conteudo2());
		}
	}
}