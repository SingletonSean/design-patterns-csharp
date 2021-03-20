using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Menus
{
    public class MenuBuilder
    {
        private readonly IEnumerable<IMenuItem> _menuItems;

        private bool _withDiscounts;
        private double _discountPercentage;
        
        private bool _withDailySpecial;
        private IMenuItem _dailySpecialMenuItem;

        public MenuBuilder(IEnumerable<IMenuItem> menuItems)
        {
            _menuItems = menuItems;
        }

        public MenuBuilder WithDiscounts(double discountPercentage)
        {
            _withDiscounts = true;
            _discountPercentage = discountPercentage;

            return this;
        }

        public MenuBuilder WithDailySpecial(IMenuItem dailySpecialMenuItem)
        {
            _withDailySpecial = true;
            _dailySpecialMenuItem = dailySpecialMenuItem;

            return this;
        }

        public IMenu Build()
        {
            IMenu menu = new Menu(_menuItems);

            if(_withDiscounts)
            {
                menu = new DiscountMenu(menu, _discountPercentage);
            }

            if (_withDailySpecial)
            {
                menu = new DailySpecialMenu(menu, _dailySpecialMenuItem);
            }

            return menu;
        }
    }
}
