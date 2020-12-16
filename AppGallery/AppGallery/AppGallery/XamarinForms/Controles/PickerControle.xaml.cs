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
    public partial class PickerControle : ContentPage
    {
        public PickerControle()
        {
            InitializeComponent();
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((Picker)sender).SelectedIndex == 0)
                ((Picker)sender).TitleColor = Color.Purple;

            else
                ((Picker)sender).TitleColor = Color.Blue;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            pMarca.SelectedIndex = -1;
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            lblInfo.Text = $"Antiga: {e.OldDate.ToString("dd/MM/yyyy")}  - Nova: {e.NewDate.ToString("dd/MM/yyyy")}";
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Time")
            {
                lblInfo2.Text = $"Time alterado";
            }
        }
    }
}