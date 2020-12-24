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
    public partial class EstiloVSM : ContentPage
    {
        public EstiloVSM()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var view = (View)sender;
            if(e.NewTextValue.StartsWith("#"))
            {
                VisualStateManager.GoToState(view, "Valido");
            }
            else
            {
                VisualStateManager.GoToState(view, "Invalido");
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            txtHex.IsEnabled = !txtHex.IsEnabled;
        }
    }
}