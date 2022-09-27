using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Observer
{
    public class OrderItemView
    {
        private readonly OrderItemViewModel _viewModel;

        public OrderItemView(OrderItemViewModel viewModel)
        {
            _viewModel = viewModel;

            Print();
        }

        public void ClickIncreaseQuantityButton()
        {
            _viewModel.IncreaseQuantityCommand.Execute(null);
        }

        public void Print()
        {
            Console.WriteLine($"{_viewModel.Description} x{_viewModel.Quantity}");
        }
    }
}
