using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Menus
{
    public class DiscountMenu : IMenu
    {
        private readonly IMenu _menu;
        private readonly double _discountPercentage;

        public IEnumerable<IMenuItem> Items => _menu.Items.Select(ToDiscountMenuItems);

        public DiscountMenu(IMenu menu, double discountPercentage)
        {
            _menu = menu;
            _discountPercentage = discountPercentage;
        }

        private IMenuItem ToDiscountMenuItems(IMenuItem menuItem)
        {
            return new DiscountMenuItem(menuItem, _discountPercentage);
        }
    }
}
