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
    public partial class TrocarTema : ContentPage
    {
        private bool light = false;
        public TrocarTema()
        {
            InitializeComponent();
        }

        private void trocar_tema(object sender, EventArgs e)
        {
            if (light)
                Resources = new LighTheme();
            else
                Resources = new DarkTheme();

            light = !light;
        }

    }
}