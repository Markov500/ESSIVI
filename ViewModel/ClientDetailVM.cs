using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Maui.Controls.Maps;
using System.Collections.ObjectModel;

namespace ESSIVI.ViewModel;

[QueryProperty("Cli", "Client")]
public partial class ClientDetailVM : ObservableObject
{
	
	Client cli;

    [ObservableProperty]
    ObservableCollection<Pin> pins;

    [ObservableProperty]
	bool isVisible;

	public Client Cli
	{
		get => cli;
		set
		{
			SetProperty(ref cli, value);
			WeakReferenceMessenger.Default.Send(new MapHandler(cli));
		}
	}
	public ClientDetailVM()
	{
		this.IsVisible= false;
		this.Pins = new ObservableCollection<Pin>();
		
    }

    [RelayCommand]
    void ShowMap()
    {
		try
		{
			Pin  p = new Pin
			{
				Type = PinType.Place,
				Label = Cli.Nom,
				Address = Cli.Telephone,
				Location = Cli.Localisation
			};
			this.Pins.Add(p);
		}
		catch(Exception ex)
		{
			Shell.Current.DisplayAlert("Erreur survenue", ex.Message, "OK");
		}
		finally
		{ this.IsVisible = true; }

    }

	[RelayCommand]
	async Task GoBack()
	{
		await Shell.Current.GoToAsync("..");
	}

}
