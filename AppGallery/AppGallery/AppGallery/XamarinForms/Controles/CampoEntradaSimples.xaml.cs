using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CampoEntradaSimples : ContentPage
    {
        public CampoEntradaSimples()
        {
            InitializeComponent();
        }

        private void FocusEvento(object sender, FocusEventArgs e)
        {
            Foco.Text = "Em foco";
        }

        private void SemFocoEVT(object sender, FocusEventArgs e)
        {
            TFoco.Text = "Sem foco";
        }

        private void txtChEVT(object sender, TextChangedEventArgs e)
        {
            Mudanca.Text = e.NewTextValue + " " + e.NewTextValue.Length;
        }

        private void txtCplEVT(object sender, EventArgs e)
        {
            Completo.Text = "Terminou";
        }
    }
}