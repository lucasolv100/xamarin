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
    public partial class RefreshControle : ContentPage
    {
        public RefreshControle()
        {
            InitializeComponent();
        }

        private void RefreshView_Refreshing(object sender, EventArgs e)
        {
            lblStatus.Text = $"Atualizado - {DateTime.Now}";
            lblStatus.TextColor = Color.Green;

            ((RefreshView)sender).IsRefreshing = false;
        }
    }
}