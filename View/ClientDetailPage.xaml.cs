using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace ESSIVI.View;

public partial class ClientDetailPage : ContentPage
{
	public ClientDetailPage(ClientDetailVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
		WeakReferenceMessenger.Default.Register<MapHandler>(this, (o, data) =>	
		{
			Pin pin = new()
		{
			Label = vm.Cli.Nom,
			Location = vm.Cli.Localisation
			};
			carte.Pins.Add(pin);
            carte.MoveToRegion(MapSpan.FromCenterAndRadius(pin.Location, Distance.FromKilometers(1)));

        })
		;

	}
}