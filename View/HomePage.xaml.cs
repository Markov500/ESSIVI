using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace ESSIVI.View;

public partial class HomePage : ContentPage
{
	public HomePage(HomeVM vm)
	{
		InitializeComponent();
        
		BindingContext = vm;



        //foreach(var i in vm.Clients)
        //{
        //          Pin pin = new Pin
        //          {
        //              Location = i.Localisation,
        //              Label = i.Nom,
        //              Address = i.Telephone,
        //          };
        //          map.Pins.Add(pin);
        //      }


        //GeolocationRequest request = new GeolocationRequest(GeolocationAccuracy.Medium,
        //TimeSpan.FromSeconds(10));
        // var _cancelTokenSource = new CancellationTokenSource();
        //Location location =  Geolocation.Default.GetLocationAsync(request, _cancelTokenSource.Token);

        var location = Geolocation.GetLastKnownLocationAsync().Result;

        if (location != null)
        {
            map.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Location(location.Latitude, location.Longitude),
                Distance.FromMiles(1)));
        }
        else
        {
            Shell.Current.DisplayAlert("LOCALISATION", "Impossible d'accéder à votre position", "OK");
        }

    }
}