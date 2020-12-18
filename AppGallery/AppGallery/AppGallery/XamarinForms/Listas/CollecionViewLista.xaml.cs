using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollecionViewLista : ContentPage
    {

        private ObservableCollection<Categoria> _categorias { get; set; }
        public CollecionViewLista()
        {
            InitializeComponent();
            //c01.ItemsSource = GetFastFoods();
            //c02.ItemsSource = GetFastFoods();
            _categorias = GetFastFoods();
            c03.ItemsSource = _categorias;
            //c01.ItemsSource = new List<FastFood>(); //Usado para listas vazias não retornar null para evitar o bug de cabeçalho e rodapé;
        }

        private ObservableCollection<Categoria> GetFastFoods()
        {
            var hamburguer =  new Categoria { 
                new FastFood { Nome = "McDonalds", QtdFranquias = 37000 },
                new FastFood { Nome = "Subway", QtdFranquias = 44870 },
                new FastFood { Nome = "Burguer King", QtdFranquias = 15000 },
            };

            var pizzas = new Categoria {
                new FastFood { Nome = "Pizza Huts", QtdFranquias = 15000 },
                new FastFood { Nome = "Dominos", QtdFranquias = 7000 },
            };

            var mexicanas = new Categoria {
                new FastFood { Nome = "Tacobell", QtdFranquias = 7000 },
                new FastFood { Nome = "El Tambo", QtdFranquias = 7000 },
            };

            var outros = new Categoria {
                new FastFood { Nome = "Star Bucks", QtdFranquias = 26000 },
                new FastFood { Nome = "KFC", QtdFranquias = 19000 },
            };


            hamburguer.NomeCategoria = "Hamburguer";
            pizzas.NomeCategoria = "Pizzas";
            mexicanas.NomeCategoria = "Mexicanas";
            outros.NomeCategoria = "Outros";

            return new ObservableCollection<Categoria>
            {
                hamburguer,
                pizzas,
                mexicanas,
                outros
            };

        }

        private void c03_RemainingItemsThresholdReached(object sender, EventArgs e)
        {
            var marmitex = new Categoria {
                new FastFood { Nome = "John Marmitas", QtdFranquias = 2 },
                new FastFood { Nome = "Cantina da marmita", QtdFranquias = 3 },
                new FastFood { Nome = "Churrascaria Brasil", QtdFranquias = 4 },
                new FastFood { Nome = "Churrascaria SP", QtdFranquias = 5 },
                new FastFood { Nome = "Churrascaria PR", QtdFranquias = 6 },
            };

            marmitex.NomeCategoria = "Marmitex";

            _categorias.Add(marmitex);

            c03.RemainingItemsThreshold = -1; //não existem mais dados no servidor

        }

        private void c03_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string resp = "";
            foreach (FastFood item in c03.SelectedItems)
            {
                resp += $"{item.Nome} - ";
            }

            lblSelecao.Text = resp;
        }
    }

    public class FastFood {
        public string Nome { get; set; }
        public int QtdFranquias { get; set; }
    }

    public class Categoria  : List<FastFood> {
        public string NomeCategoria { get; set; }
    }


}