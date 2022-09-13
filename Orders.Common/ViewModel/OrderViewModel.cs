using Orders.Common.DataProvider;
using Orders.Common.Model;
using Orders.Common.ViewModel.Command;
using System.Windows.Input;

namespace Orders.Common.ViewModel
{
    public class OrderViewModel : ViewModelBase
    {
        private Order _order;

        public Order Order
        {
            get => _order;
            set
            {
                if (_order != value)
                {
                    _order = value;
                    RaisePropertyChanged();
                }
            }
        }

        private OrderDataProvider _orderDataProvider = new OrderDataProvider();

        public DelegateCommand SaveCommand { get; }

        public ICommand SaveOrder { get; set; }


        public OrderViewModel()
        {
            _order = new Order() { OrderID = -1, Customer = "", OrderDate = DateTime.Now };

            SaveCommand = new DelegateCommand(Save, () => CanSave);
        }

        public OrderViewModel(Order order)
        {
            _order = order;

            SaveCommand = new DelegateCommand(Save, () => CanSave);
        }

        public bool CanSave => !string.IsNullOrEmpty(CustomerName) && CustomerName.Length >= 3;

        public void Save()
        {
            throw new NotImplementedException();
        }

        public int OrderID
        {
            get => _order.OrderID;
            set
            {
                if (_order.OrderID != value)
                {
                    _order.OrderID = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string CustomerName
        {
            get => _order.Customer;
            set
            {
                if (_order.Customer != value)
                {
                    _order.Customer = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(CanSave));
                    SaveCommand.RaiseCanExecuteChanged();
                }
            }
        }

        public DateTime OrderDate
        {
            get => _order.OrderDate;
            set
            {
                if (_order.OrderDate != value)
                {
                    _order.OrderDate = value;
                    RaisePropertyChanged();
                }
            }
        }
    }
}
