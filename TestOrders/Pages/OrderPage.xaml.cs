using Orders.Common.ViewModel;

namespace TestOrders.Pages;

public partial class OrderPage : ContentPage
{
	public OrderPage()
	{
		InitializeComponent();

		BindingContext = new OrderViewModel();
	}
}