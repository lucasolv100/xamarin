using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewLista : ContentPage
    {
        public ListViewLista()
        {
            InitializeComponent();

            lista01.ItemsSource = GetMarcas();
        }

        private List<Marca> GetMarcas()
        {
            return new List<Marca>()
            {
                GetListaCarrosFIAT(),
                GetListaCarrosRENAULT()
            };
        }

        private Marca GetListaCarrosFIAT()
        {
            var fiat = new Marca()
            {
                new Carro { Nome = "Mobi", Descricao="Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno", Motor="1.0", ItensSeries="Air Bags, Direção Hidraulica" },
                new Carro { Nome = "Uno", Descricao="qq coisa", Motor="1.0 - 1.6", ItensSeries="Air Bags, Direção Hidraulica" },
                new Carro { Nome = "Argo", Descricao="qq coisa2 ", Motor="1.0 - 1.4", ItensSeries="Air Bags, Direção Hidraulica" },
                new Carro { Nome = "Cronos", Descricao="qq coisa3", Motor="1.0 - 1.6", ItensSeries="Air Bags, Direção Hidraulica" },
                new Carro { Nome = "Toro", Descricao="qq coisa4", Motor="1.8 - 2.4", ItensSeries="Air Bags, Direção Hidraulica, Turbo" },
                new Carro { Nome = "Mobi", Descricao="Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno", Motor="1.0", ItensSeries="Air Bags, Direção Hidraulica" },
                new Carro { Nome = "Uno", Descricao="qq coisa", Motor="1.0 - 1.6", ItensSeries="Air Bags, Direção Hidraulica" },
                new Carro { Nome = "Argo", Descricao="qq coisa2 ", Motor="1.0 - 1.4", ItensSeries="Air Bags, Direção Hidraulica" },
                new Carro { Nome = "Cronos", Descricao="qq coisa3", Motor="1.0 - 1.6", ItensSeries="Air Bags, Direção Hidraulica" },
                new Carro { Nome = "Toro", Descricao="qq coisa4", Motor="1.8 - 2.4", ItensSeries="Air Bags, Direção Hidraulica, Turbo" },

            };

            fiat.NomeMarca = "FIAT";
            return fiat;
        }
        private Marca GetListaCarrosRENAULT()
        {
            var renault = new Marca()
            {
                new Carro { Nome = "Sandero", Descricao="Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno", Motor="1.0", ItensSeries="Air Bags, Direção Hidraulica" },
                new Carro { Nome = "Logan", Descricao="qq coisa", Motor="1.0 - 1.6", ItensSeries="Air Bags, Direção Hidraulica" },
                new Carro { Nome = "Captur", Descricao="qq coisa2 ", Motor="1.3 - 1.6", ItensSeries="Air Bags, Direção Hidraulica" },
                new Carro { Nome = "Duster", Descricao="qq coisa3", Motor="1.3 - 1.6", ItensSeries="Air Bags, Direção Hidraulica" },
                new Carro { Nome = "Sandero", Descricao="Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno Carro pequeno", Motor="1.0", ItensSeries="Air Bags, Direção Hidraulica" },
                new Carro { Nome = "Logan", Descricao="qq coisa", Motor="1.0 - 1.6", ItensSeries="Air Bags, Direção Hidraulica" },
                new Carro { Nome = "Captur", Descricao="qq coisa2 ", Motor="1.3 - 1.6", ItensSeries="Air Bags, Direção Hidraulica" },
                new Carro { Nome = "Duster", Descricao="qq coisa3", Motor="1.3 - 1.6", ItensSeries="Air Bags, Direção Hidraulica" },
            };

            renault.NomeMarca = "RENAULT";
            return renault;
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            var p = ((MenuItem)sender).CommandParameter;
            DisplayAlert("Clicou no visualizar", $"Registro -> {((Carro)p).Nome}", "OK");
        }

        private void IrParaRenault(object sender, EventArgs e)
        {
            var renault = (List<Marca>)lista01.ItemsSource;
            var r = renault.Where(w => w.NomeMarca == "RENAULT").FirstOrDefault();
            lista01.ScrollTo(r.First(), ScrollToPosition.Start, true);
        }

        private void lista01_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DisplayAlert("Tocado", "Item Tocado", "Ok");
        }
    }

    public class Carro
    {
        public string Nome { get; set; }
        public string Motor { get; set; }
        public string Descricao { get; set; }
        public string ItensSeries { get; set; }
    }

    public class Marca : List<Carro>
    {
        public string NomeMarca { get; set; }
    }
}