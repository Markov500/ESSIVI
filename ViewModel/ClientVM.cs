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
				Nom = "ETS Aladji",
				Localisation = new(6.208264,1.188625)
				
				
			}
		);

		Clients.Add(
			new Client
			{
				Id = 2,
				Nom = "ETS Tout est ici",
                Localisation = new(11.2088864, -9.198625)
            }
		);
	}

	[RelayCommand]
	async Task SeeDetails(Client Cli)
	{
		
		// Shell.Current.GoToAsync($"{nameof(ClientDetailPage)}?Cli={JsonSerializer.Serialize(Cli)}");
		await Shell.Current.GoToAsync($"{nameof(ClientDetailPage)}?",
			new Dictionary<string, object>
			{
				["Cli"] = Cli,
			}
			);
	}


	[RelayCommand]
	void GotoAddPage()
	{
		_navigation.PushAsync(new ClientAddPage());
	}


}
