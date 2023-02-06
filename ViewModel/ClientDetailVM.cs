using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json;

namespace ESSIVI.ViewModel;

[QueryProperty("Cli", "Cli")]
partial class ClientDetailVM : ObservableObject
{
	[ObservableProperty]
	Client cli;

	

	public ClientDetailVM() 
	{
		
	}


}
