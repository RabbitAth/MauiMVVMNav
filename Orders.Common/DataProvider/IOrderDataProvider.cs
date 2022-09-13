using Orders.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Common.DataProvider
{
    public interface IOrderDataProvider
    {
        IEnumerable<Order> GetAllOrders();
    }
}
