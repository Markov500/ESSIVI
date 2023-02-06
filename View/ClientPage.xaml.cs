namespace ESSIVI.View;

public partial class ClientPage : ContentPage
{
	public ClientPage()
	{
		InitializeComponent();

		BindingContext = new ClientVM(Navigation);
	}
}