﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Paginas.Navegacao
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaInserida : ContentPage
	{
		public PaginaInserida()
		{
			InitializeComponent();
		}

		private void Inicio(object sender, EventArgs e)
		{
			App.Current.MainPage = new NavigationPage(new Conteudo1());
		}
	}
}