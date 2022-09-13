using TestOrders.Pages;

namespace TestOrders;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(OrdersPage), typeof(OrdersPage));
        Routing.RegisterRoute(nameof(OrderPage), typeof(OrderPage));
    }
}
