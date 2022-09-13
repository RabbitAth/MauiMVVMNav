namespace TestOrders.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    async void OnButtonClicked(object sender, EventArgs args)
    {
		await Shell.Current.GoToAsync(nameof(OrdersPage));
    }
}

