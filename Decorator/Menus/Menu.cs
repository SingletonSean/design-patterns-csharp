using System.Collections.Generic;

namespace Decorator.Menus
{
    public class Menu : IMenu
    {
        public IEnumerable<IMenuItem> Items { get; }

        public Menu(IEnumerable<IMenuItem> menuItems)
        {
            Items = menuItems;
        }
    }
}
