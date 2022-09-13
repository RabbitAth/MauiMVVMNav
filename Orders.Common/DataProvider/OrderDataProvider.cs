using Orders.Common.Model;

namespace Orders.Common.DataProvider
{
    public class OrderDataProvider : IOrderDataProvider
    {
        public IEnumerable<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>
            {
               new Order { OrderID = 1, Customer = "CustomerA", OrderDate = new DateTime(2022, 08, 25, 8, 0, 0) },
               new Order { OrderID = 2, Customer = "CustomerB", OrderDate = new DateTime(2022, 08, 26, 9, 0, 0) },
               new Order { OrderID = 3, Customer = "CustomerC", OrderDate = new DateTime(2022, 08, 27, 10, 0, 0) },
               new Order { OrderID = 4, Customer = "CustomerD", OrderDate = new DateTime(2022, 08, 28, 11, 0, 0) },
            };

            return orders;
        }
    }
}
