using System;

namespace Decorator.Menus
{
    public interface IMenuItem
    {
        string Name { get; }
        double Price { get; }
        bool IsSpecial { get; }
    }
}