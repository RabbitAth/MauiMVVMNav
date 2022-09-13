using Orders.Common.ViewModel;

namespace TestOrders;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		BindingContext = new MainPageViewModel();
	}
}
