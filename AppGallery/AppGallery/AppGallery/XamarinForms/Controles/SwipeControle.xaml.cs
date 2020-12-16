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
    public partial class SwipeControle : ContentPage
    {
        public SwipeControle()
        {
            InitializeComponent();
        }

        private void DetalheSW(object sender, EventArgs e)
        {
            lblExcluir.Text = "Abriu Detalhe";
        }

        private void EditarSW(object sender, EventArgs e)
        {
            lblExcluir.Text = "Editou";
        }

        private void ExcluirSW(object sender, EventArgs e)
        {
            lblExcluir.Text = "Excluiu";
        }
    }
}