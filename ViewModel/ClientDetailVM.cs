using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json;

namespace ESSIVI.ViewModel;

[QueryProperty("Cli", "Cli")]
partial class ClientDetailVM : ObservableObject
{
	[ObservableProperty]
	string cli;

	//[ObservableProperty]
	//Client client;

	public ClientDetailVM() 
	{
		//Client= new Client();
		//Client = JsonSerializer.Deserialize<Client>(cli);
	}


}
