using System.Collections.Generic;

namespace Decorator.Menus
{
    public interface IMenu
    {
        IEnumerable<IMenuItem> Items { get; }
    }
}
