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
	public partial class Conteudo2 : ContentPage
	{
		public Conteudo2()
		{
			InitializeComponent();
		}

		private void VoltarAsync(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
	}
}