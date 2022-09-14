using Orders.Common.Model;

namespace Orders.Common.Service
{
    public interface IOrderNavigation
    {
        void NavigateToOrdersAsync();

        void NavigateToOrderAsync(Order order);

        void NavigateToOrderAsync();
    }
}
