using System.ComponentModel;
using System.Windows.Input;

namespace Observer
{
    public class OrderItemViewModel : INotifyPropertyChanged
    {
        public string Description { get; }

        private int _quantity;
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Quantity)));
            }
        }

        public ICommand IncreaseQuantityCommand { get; }

        public event PropertyChangedEventHandler? PropertyChanged;

        public OrderItemViewModel(string description)
        {
            Description = description;

            IncreaseQuantityCommand = new IncreaseOrderItemQuantityCommand(this);
        }
    }
}
