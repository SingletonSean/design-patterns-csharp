using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Menus
{
    public class DailySpecialMenu : IMenu
    {
        private readonly IMenu _menu;
        private readonly IMenuItem _dailySpecialMenuItem;

        public IEnumerable<IMenuItem> Items => _menu.Items.Append(_dailySpecialMenuItem);

        public DailySpecialMenu(IMenu menu, IMenuItem dailySpecialMenuItem)
        {
            _menu = menu;
            _dailySpecialMenuItem = dailySpecialMenuItem;
        }
    }
}
