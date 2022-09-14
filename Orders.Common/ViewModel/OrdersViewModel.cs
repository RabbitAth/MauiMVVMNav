using Orders.Common.DataProvider;
using Orders.Common.Model;
using Orders.Common.Service;
using Orders.Common.ViewModel.Command;
using System.Collections.ObjectModel;

namespace Orders.Common.ViewModel
{
    public class OrdersViewModel : ViewModelBase
    {
        public ObservableCollection<Order> Orders { get; } = new();

        private readonly OrderDataProvider _orderDataProvider;
        private IOrderNavigation _navigationService;

        public RelayCommand<Order> GoToOrdersCommand { get; }

        public DelegateCommand GoToNewOrderCommand { get; }

        //private Order _order;

        public OrdersViewModel(IOrderNavigation navigationService)
        {
            Orders = new ObservableCollection<Order>();
            _orderDataProvider = new OrderDataProvider();
            _navigationService = navigationService;


            GoToOrdersCommand = new RelayCommand<Order>((order) => OrderDetails((Order)order));
            GoToNewOrderCommand = new DelegateCommand(NewOrder);

            Load();
        }

        public void Load()
        {
            var orders = _orderDataProvider.GetAllOrders();
            Orders.Clear();

            foreach (var order in orders)
                Orders.Add(order);
        }

        public void OrderDetails(Order order)
        {
            if (order == null)
                return;

            _navigationService.NavigateToOrderAsync(order);
        }

        private void NewOrder()
        {
            _navigationService.NavigateToOrderAsync();
        }
    }
}
