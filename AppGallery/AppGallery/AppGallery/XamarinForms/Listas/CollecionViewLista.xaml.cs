using System;
using System.Collections.Generic;
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
        public CollecionViewLista()
        {
            InitializeComponent();
            c01.ItemsSource = GetFastFoods();
            c02.ItemsSource = GetFastFoods();
            //c01.ItemsSource = new List<FastFood>(); //Usado para listas vazias não retornar null para evitar o bug de cabeçalho e rodapé;
        }

        private List<FastFood> GetFastFoods()
        {
            return new List<FastFood>() { 
                new FastFood { Nome = "McDonalds", QtdFranquias = 37000 },
                new FastFood { Nome = "Subway", QtdFranquias = 44870 },
                new FastFood { Nome = "Burguer King", QtdFranquias = 15000 },
                new FastFood { Nome = "Star Bucks", QtdFranquias = 26000 },
                new FastFood { Nome = "KFC", QtdFranquias = 19000 },
                new FastFood { Nome = "Pizza Huts", QtdFranquias = 15000 },
                new FastFood { Nome = "Tacobell", QtdFranquias = 7000 },
            };

        }


    }

    public class FastFood {
        public string Nome { get; set; }
        public int QtdFranquias { get; set; }
    }

}