using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace ESSIVI.ViewModel;

partial class ClientVM : ObservableObject
{
	[ObservableProperty]
	ObservableCollection<Client> clients;
	INavigation _navigation;
	public ClientVM( INavigation navigation) 
	{
		this._navigation= navigation;
		clients= new ObservableCollection<Client>();
		Clients.Add(
			new Client 
			{
				Id= 1,
				Nom = "ETS Aladji"
			}
		);

		Clients.Add(
			new Client
			{
				Id = 2,
				Nom = "ETS Tout est ici"
			}
		);
	}

	[RelayCommand]
	async Task SeeDetails(string Cli)
	{
		
		// Shell.Current.GoToAsync($"{nameof(ClientDetailPage)}?Cli={JsonSerializer.Serialize(Cli)}");
		await Shell.Current.GoToAsync($"{nameof(ClientDetailPage)}?Cli={Cli}");
	}


	[RelayCommand]
	void GotoAddPage()
	{
		_navigation.PushAsync(new ClientAddPage());
	}


}
