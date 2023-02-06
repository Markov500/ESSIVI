namespace ESSIVI.View;

public partial class ClientDetailPage : ContentPage
{
	public ClientDetailPage()
	{
		InitializeComponent();
		BindingContext = new ClientDetailVM();
	}
}