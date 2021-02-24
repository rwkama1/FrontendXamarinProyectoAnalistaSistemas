using Microsoft.AspNetCore.SignalR.Client;

using System;
using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace XamGps
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VerOrdenEnvioCliente : ContentPage
	{
        //Position addressPosition;
        //HubConnection hubConnection;
       
        public VerOrdenEnvioCliente ()
		{
            InitializeComponent();
            btnRecibir.Clicked += BtnVerC_Clicked;


        }
        private  void BtnVerC_Clicked(object sender, EventArgs e)
        {
            var signalr = new Signalr();
            signalr.RecibirLocation();
        }
        //private  void RecibirLocation()
        //{
           
        //    hubConnection.On<int,double, double>("locationMessage", (orden,latitude, longitude) =>
        //    {
        //        addressPosition = new Position(latitude, longitude);
        //        Xamarin.Essentials.Map.OpenAsync(addressPosition.Latitude, addressPosition.Longitude);


        //    });
         
        //}
       

    }
}