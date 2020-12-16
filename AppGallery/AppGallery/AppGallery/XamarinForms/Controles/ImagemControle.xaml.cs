using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery.XamarinForms.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImagemControle : ContentPage
    {
        public ImagemControle()
        {
            InitializeComponent();

            Task.Run(async () =>
            {
                HttpClient client = new HttpClient();
                //client.MaxResponseContentBufferSize = 256000;
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tocken);
                client.DefaultRequestHeaders.Add("accept-ranges", "bytes");
                //client.DefaultRequestHeaders.Add("content-type", "image/jpeg");
                try
                {
                    Stream stream = await client.GetStreamAsync("https://media.iatiseguros.pt/wp-content/uploads/sites/2/2018/11/lago-mcdonald.jpg");
                    imgInterWeb.Source = ImageSource.FromStream(() => stream);
                }
                catch (Exception ex)
                {

                    throw;
                }
                
            });
        }
    }
}