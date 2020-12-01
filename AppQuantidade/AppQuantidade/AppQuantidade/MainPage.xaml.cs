using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppQuantidade
{
	public partial class MainPage : ContentPage
	{
		int qtd = 1;
		public MainPage()
		{
			InitializeComponent();
			Qtd.Text = qtd.ToString();
		}

		private void btnMais_Clicked(object sender, EventArgs e)
		{
			qtd++;
			Qtd.Text = qtd.ToString();
		}

		private void btnMenos_Clicked(object sender, EventArgs e)
		{
			if (qtd > 0)
				qtd--;

			Qtd.Text = qtd.ToString();
		}
	}
}
