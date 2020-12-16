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
    public partial class CampoEditorControle : ContentPage
    {
        public CampoEditorControle()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblEVTs.Text = e.NewValue.ToString("N2");
        }

        private void Slider_DragStarted(object sender, EventArgs e)
        {
            lblEVTs.Text = "Iniciou!";
        }

        private void Slider_DragCompleted(object sender, EventArgs e)
        {
            lblEVTs.Text = "acabou!";
        }

        private void Slider_ValueChangedStep(object sender, ValueChangedEventArgs e)
        {
            int steps = 1;
            double novoPasso = Math.Round(e.NewValue / steps);
            ((Slider)sender).Value = novoPasso * 1;
        }
    }
}