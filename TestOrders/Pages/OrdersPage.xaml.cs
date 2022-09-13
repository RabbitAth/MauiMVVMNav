using Orders.Common.ViewModel;
using TestOrders.Navigate;

namespace TestOrders.Pages;

public partial class OrdersPage : ContentPage
{
	public OrdersPage()
	{
		InitializeComponent();

		BindingContext = new OrdersViewModel(new OrderNavigationService());
	}
}