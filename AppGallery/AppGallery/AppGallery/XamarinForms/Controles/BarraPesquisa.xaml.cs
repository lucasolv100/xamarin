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
    public partial class BarraPesquisa : ContentPage
    {
        public BarraPesquisa()
        {
            InitializeComponent();
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            //botão de pesquisa clicado é colocado aqui
        }
    }
}