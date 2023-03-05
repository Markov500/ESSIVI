using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace ESSIVI.ViewModel;

public partial class ClientVM : ObservableObject
{
	[ObservableProperty]
	ObservableCollection<Client> clients;

	[ObservableProperty]
	bool isRefreshing;

	[ObservableProperty]
	String search;

	ClientService _clientService;
	//INavigation _navigation;
	public  ClientVM(ClientService clientService) 
	{
		//this._navigation = nav;
		this._clientService = clientService;
		this.Clients= new ObservableCollection<Client>();
		this.IsRefreshing = true;
		this.IsRefreshing = false;
		//this.GetClients();
	}

	[RelayCommand]
	async Task SeeDetails(Client Cli)
	{
		
		// Shell.Current.GoToAsync($"{nameof(ClientDetailPage)}?Cli={JsonSerializer.Serialize(Cli)}");

		await Shell.Current.GoToAsync($"{nameof(ClientDetailPage)}",
			new Dictionary<string, object>
			{
				["Client"] = Cli,
			}
			);
	}


	[RelayCommand]
	async Task GotoAddPage()
	{
		//await _navigation.PushAsync(new ClientAddPage());
		await Shell.Current.GoToAsync(nameof(ClientAddPage));
	}


	[RelayCommand]
    async Task GetClients()
	{
		

		try
		{
			this.Clients.Clear();

			var cli = _clientService.GetClients();


            foreach (var client in cli)
			{
				Clients.Add(client);
			}
		}
		catch(Exception ex)
		{
			await Shell.Current.DisplayAlert("Erreur", ex.Message, "OK");
		}

        this.IsRefreshing = false;
    }


	[RelayCommand]
	void SearchClient()
	{
        

		if(this.Search != string.Empty)
		{
            var cli = _clientService.GetClients().Where(c => c.Nom.ToLower().Contains(this.Search.ToLower()));
			this.Clients.Clear();
            foreach (Client client in cli)
            {
                this.Clients.Add(client);
            }

        }
		
		
	}

}
