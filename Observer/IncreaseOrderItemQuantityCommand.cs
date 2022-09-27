using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Observer
{
    public class IncreaseOrderItemQuantityCommand : ICommand
    {
        private readonly OrderItemViewModel _viewModel;

        public IncreaseOrderItemQuantityCommand(OrderItemViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;

        public void Execute(object? parameter)
        {
            _viewModel.Quantity++;
        }
    }
}
