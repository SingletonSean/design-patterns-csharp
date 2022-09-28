using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Observer
{
    public class OrderItemView : IDisposable
    {
        private readonly OrderItemViewModel _viewModel;

        public OrderItemView(OrderItemViewModel viewModel)
        {
            _viewModel = viewModel;

            _viewModel.PropertyChanged += ViewModel_PropertyChanged;

            Print();
        }

        public void Dispose()
        {
            _viewModel.PropertyChanged -= ViewModel_PropertyChanged;
        }

        private void ViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
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
