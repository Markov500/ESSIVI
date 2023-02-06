namespace ESSIVI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ClientAddPage), typeof(ClientAddPage));
		Navigation.PushAsync(new LoginPage());
	}
}
