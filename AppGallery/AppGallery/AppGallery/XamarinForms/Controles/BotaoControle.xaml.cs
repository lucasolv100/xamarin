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
    public partial class BotaoControle : ContentPage
    {
        public BotaoControle()
        {
            InitializeComponent();
        }

        private void PressionadoACT(object sender, EventArgs e)
        {
            lblPressionado.Text = "Pressionado!!";
        }

        private void ClicadoACT(object sender, EventArgs e)
        {
            lblClicado.Text = "Clicado!!";
        }

        private void LiberadoACT(object sender, EventArgs e)
        {
            lblLiberado.Text = "Liberado!!";
        }
    }
}