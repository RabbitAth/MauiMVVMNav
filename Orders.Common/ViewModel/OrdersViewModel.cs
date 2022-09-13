using Orders.Common.DataProvider;
using Orders.Common.Model;
using Orders.Common.Service;
using Orders.Common.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Orders.Common.ViewModel
{
    public class OrdersViewModel : ViewModelBase
    {
        public ObservableCollection<Order> Orders { get; } = new();

        private readonly OrderDataProvider _orderDataProvider;
        private IOrderNavigation _navigationService;

        public RelayCommand<Order> GoToOrdersCommand { get; }

        private Order _order;

        public OrdersViewModel(IOrderNavigation navigationService)
        {
            Orders = new ObservableCollection<Order>();
            _orderDataProvider = new OrderDataProvider();
            _navigationService = navigationService;

            _order = new Order();

            GoToOrdersCommand = new RelayCommand<Order>((order) => OrderDetails(_order));

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
    }
}
