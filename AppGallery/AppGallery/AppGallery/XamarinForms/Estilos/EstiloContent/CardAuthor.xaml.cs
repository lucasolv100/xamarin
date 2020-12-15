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
    public partial class CardAuthor : ContentView
    {

        public static readonly BindableProperty NomeProperty = BindableProperty.Create("Nome", typeof(string), typeof(CardAuthor));
        public static readonly BindableProperty DescricaoProperty = BindableProperty.Create("Descricao", typeof(string), typeof(CardAuthor));
        public static readonly BindableProperty BVColorProperty = BindableProperty.Create("BVColor", typeof(Color), typeof(CardAuthor));

        public string Nome { get { return (string)GetValue(NomeProperty); } set { SetValue(NomeProperty, value); } }
        public string Descricao { get { return (string)GetValue(DescricaoProperty); } set { SetValue(DescricaoProperty, value); } }
        public Color BVColor { get { return (Color)GetValue(BVColorProperty); } set { SetValue(BVColorProperty, value); } }
        public CardAuthor()
        {
            InitializeComponent();
        }
    }
}