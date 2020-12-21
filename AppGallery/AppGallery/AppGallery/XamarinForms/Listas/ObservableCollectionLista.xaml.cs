using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Listas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObservableCollectionLista : ContentPage
    {
        private ObservableCollection<Pessoa> Pessoas { get; set; }
        public ObservableCollectionLista()
        {
            InitializeComponent();
            Pessoas = GetListaPessoas();
            Lista01.ItemsSource = Pessoas;
        }

        private ObservableCollection<Pessoa> GetListaPessoas()
        {
            return new ObservableCollection<Pessoa> {
                new Pessoa {Nome = "João", Sobrenome="Souza"},
                new Pessoa {Nome = "Maria", Sobrenome="Souza"},
                new Pessoa {Nome = "José", Sobrenome="Souza"},
            };

        }

        private void AddItem(object sender, EventArgs e)
        {
            Pessoas[0].Nome = "Aline";
            Pessoas.Add(new Pessoa { Nome = "Johnes", Sobrenome = "Souza" });
        }

        private void RemoveItem(object sender, EventArgs e)
        {
            Pessoas.RemoveAt(0);
        }
    }

    public class Pessoa : INotifyPropertyChanged
    {
        private string _nome;
        private string _sobrenome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
                RaisedPropertyChanged("Nome");
            }
        }
        public string Sobrenome { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisedPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

}