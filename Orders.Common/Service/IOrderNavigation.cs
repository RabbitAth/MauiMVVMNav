using Orders.Common.Model;

namespace Orders.Common.Service
{
    public interface IOrderNavigation
    {
        void NavigateToOrdersAsync();// => throw new NotImplementedException();

        void NavigateToOrderAsync(Order order);// => throw new NotImplementedException();
    }
}
