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
    public partial class IndicadorAtividadeControle : ContentPage
    {
        double Contador = 0.0;
        public IndicadorAtividadeControle()
        {
            InitializeComponent();
        }

        private void Processar_Clicked(object sender, EventArgs e)
        {
            Contador += 0.1;
            BRProgresso.ProgressTo(Contador, 500, Easing.CubicOut);
        }
    }
}