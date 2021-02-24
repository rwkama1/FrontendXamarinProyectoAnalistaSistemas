using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamGps
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VerOrdenEnvio : ContentPage
	{
		public VerOrdenEnvio (OrdenEnvio orden)
		{
			InitializeComponent ();
          
            BindingContext = orden;
            btnDestinoD.Clicked += BtnDestinoM_Clicked;
            btnEnvioD.Clicked += BtnEnvioD_Clicked;

        }
        
        private async void BtnDestinoM_Clicked(object sender, EventArgs e)
        {
            var ordenenviosesion = Application.Current.Properties["OrdenEnvio"];
            var orden = (OrdenEnvio)ordenenviosesion;
            var placemark = new Placemark
                {
                    CountryName = "Uruguay",
                    Locality = orden.LocalidadOE,
                    Thoroughfare = orden.UbicacionOE,
                };
                var options = new MapLaunchOptions { Name = orden.UbicacionOE };

                await Xamarin.Essentials.Map.OpenAsync(placemark);
        }
        private async void BtnEnvioD_Clicked(object sender, EventArgs e)
        {

            var ordenenvios = Application.Current.Properties["OrdenEnvio"];
            var o = (OrdenEnvio)ordenenvios;
            var signalr = new Signalr();
             signalr.EnviarCoordenadas(o.IdOE);
            await DisplayAlert("Enviado", "Las Coordenadas han sido enviadas", "OK");
        }
    }
}