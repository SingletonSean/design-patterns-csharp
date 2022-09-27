using System.Windows.Input;

namespace Observer
{
    public class OrderItemViewModel
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

                View.Print();
            }
        }

        public OrderItemView View { get; set; }

        public ICommand IncreaseQuantityCommand { get; }

        public OrderItemViewModel(string description)
        {
            Description = description;

            IncreaseQuantityCommand = new IncreaseOrderItemQuantityCommand(this);
        }
    }
}
