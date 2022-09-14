using Orders.Common.Model;
using Orders.Common.ViewModel;

namespace TestOrders.Pages;

[QueryProperty(nameof(order), "Order")]
public partial class OrderPage : ContentPage
{
	public Order order
	{
		set
		{
			Load(value);
        }
	}

	public OrderPage()
	{
		InitializeComponent();

        BindingContext = new OrderViewModel();
    }

	private void Load(Order order)
	{
        if (order != null)
            BindingContext = new OrderViewModel(order);

        else BindingContext = new OrderViewModel();
    }
}