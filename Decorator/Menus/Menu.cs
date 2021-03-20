using System.Collections.Generic;

namespace Decorator.Menus
{
    public class Menu : IMenu
    {
        public IEnumerable<IMenuItem> MenuItems { get; }

        public Menu(IEnumerable<IMenuItem> menuItems)
        {
            MenuItems = menuItems;
        }
    }
}
