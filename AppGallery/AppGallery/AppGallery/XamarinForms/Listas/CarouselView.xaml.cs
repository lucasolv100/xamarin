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
    public partial class CarouselView : ContentPage
    {
        public CarouselView()
        {
            InitializeComponent();

            carousel01.ItemsSource = GetColaboradores();
        }

        private List<Colaborador> GetColaboradores()
        {
            return new List<Colaborador>
            {
                new Colaborador{Nome = "João", Cargo = "Web Designer", Descricao = "Está na equipe a 10 anos, conhece css photoshop, aftereffects, etc"},
                new Colaborador{Nome = "Felipe", Cargo = "Programador Java", Descricao = "Está na equipe a 10 anos, conhece de tudo"},
                new Colaborador{Nome = "Lucas", Cargo = "Programador Node", Descricao = "Está na equipe a 10 anos"}
            };
        }
    }

    public class Colaborador
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Descricao { get; set; }
    }

}