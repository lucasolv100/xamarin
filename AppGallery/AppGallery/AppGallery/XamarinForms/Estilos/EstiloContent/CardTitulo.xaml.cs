using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Estilos.EstiloContent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CardTitulo : ContentView
    {
        private string _titulo;
        private string _texto;
        private Color _cor;
        public string Titulo { 
            get { return _titulo; }
            set { _titulo = value; CardTituloLB.Text = _titulo; }
        }
        public string Texto
        {
            get { return _texto; }
            set { _texto = value; CardTexto.Text = _texto; }
        }
        public Color CorFundo
        {
            get { return _cor; }
            set { _cor = value; Card.BackgroundColor = _cor; }
        }
        public CardTitulo()
        {
            InitializeComponent();
            Card.BackgroundColor = CorFundo;
            CardTituloLB.Text = Titulo;
            CardTexto.Text = Texto;
        }
    }
}