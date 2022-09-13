using Orders.Common.Model;
using Orders.Common.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOrders.Pages;

namespace TestOrders.Navigate
{
    public class OrderNavigationService : IOrderNavigation
    {
        public void NavigateToOrdersAsync()
        {
            Shell.Current.GoToAsync(nameof(OrdersPage));
        }

        public void NavigateToOrderAsync(Order order)
        {
            Shell.Current.GoToAsync(nameof(OrderPage), true, new Dictionary<string, object> { { "Order", order } });
        }        
    }
}
