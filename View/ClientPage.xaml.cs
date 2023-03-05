namespace ESSIVI.View;

public partial class ClientPage : ContentPage
{
	public ClientPage(ClientVM vm)
	{
		InitializeComponent();

		BindingContext = vm;

	}
}