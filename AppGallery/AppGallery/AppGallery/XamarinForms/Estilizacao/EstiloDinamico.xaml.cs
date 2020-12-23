using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Estilizacao
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EstiloDinamico : ContentPage
    {
        public EstiloDinamico()
        {
            InitializeComponent();
        }

        private void TrocarCor(object sender, EventArgs e)
        {
            Resources["Primaria"] = Color.FromHex(corEntrada.Text);
        }
    }
}