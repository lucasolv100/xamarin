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
    public partial class CarouselView : ContentPage
    {
        private ObservableCollection<Colaborador> Colaboradores { get; set; }
        public CarouselView()
        {
            InitializeComponent();
            Colaboradores = GetColaboradores();
            carousel01.ItemsSource = Colaboradores;
        }

        private ObservableCollection<Colaborador> GetColaboradores()
        {
            Colaboradores = new ObservableCollection<Colaborador>
            {
                new Colaborador{Nome = "João", Cargo = "Web Designer", Descricao = "Está na equipe a 10 anos, conhece css photoshop, aftereffects, etc"},
                new Colaborador{Nome = "Felipe", Cargo = "Programador Java", Descricao = "Está na equipe a 10 anos, conhece de tudo"},
                new Colaborador{Nome = "Lucas", Cargo = "Programador Node", Descricao = "Está na equipe a 10 anos"},
                new Colaborador{Nome = "José", Cargo = "Programador Node", Descricao = "Está na equipe a 10 anos"},
                new Colaborador{Nome = "Maria", Cargo = "Programador Node", Descricao = "Está na equipe a 10 anos"}
            };

            return Colaboradores;
        }

        private void carousel01_RemainingItemsThresholdReached(object sender, EventArgs e)
        {
            Colaboradores.Add(new Colaborador { Nome = "Josefina", Cargo = "Programador Node", Descricao = "Está na equipe a 10 anos" });
            Colaboradores.Add(new Colaborador { Nome = "Rogério", Cargo = "Programador Node", Descricao = "Está na equipe a 10 anos" });
            Colaboradores.Add(new Colaborador { Nome = "Roberta", Cargo = "Programador Node", Descricao = "Está na equipe a 10 anos" });
        }
    }

    public class Colaborador
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public string Descricao { get; set; }
    }

}