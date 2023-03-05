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
    [ObservableProperty]
    bool animationIsVisible;

	INavigation _navigation;
	public LoginVM(INavigation nav)
	{
		this.error = string.Empty;
		this.animationIsVisible = false;
		this._navigation = nav;

	}

	[RelayCommand]
	async Task Connect()
	{
        this.Error = string.Empty;
        
        this.AnimationIsVisible = true;
        await Task.Delay(2000);

		Agent a = new AgentService().ConnectAgent(this.NumId, this.Mpass);
        if (a is not  null)
		{
			//await App.Current.MainPage.Navigation.PushAsync(new HomePage(new HomeVM()));
           // await _navigation.PushAsync(new HomePage(new HomeVM()));
			//new NavigationPage(new Home());
			await Shell.Current.GoToAsync($"///{nameof(HomePage)}");
			this.NumId = string.Empty;
            this.Mpass = string.Empty;
            //Application.Current.Properties["agent"] = a;
            this.AnimationIsVisible = false;
        }
        else
		{
            this.Mpass = string.Empty;
			this.Error = "Numéro d'identification ou mot de passe incorrect";
			this.AnimationIsVisible = false;
		}
	}
}
