using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ESSIVI.ViewModel;

partial class LoginVM : ObservableObject
{
	[ObservableProperty]
	 string numId;
	[ObservableProperty]
	 string mpass;
	[ObservableProperty]
	string error;

	INavigation Navigation { get; set; }

	public LoginVM( INavigation nav)
	{
		this.error = string.Empty;
		this.Navigation= nav;

	}

	[RelayCommand]
	async Task Connect()
	{
		if (NumId == "a" && Mpass == "a")
		{
			//this.Navigation.PushAsync(new Home());
			//new NavigationPage(new Home());
			await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
			Mpass = string.Empty;
			this.NumId = string.Empty;
			this.Error = string.Empty;
		}
		else
		{
			this.Mpass = string.Empty;
			this.Error = "Numéro d'identification ou mot de passe incorrect";
		}
	}
}
