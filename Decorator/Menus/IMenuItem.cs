using System;

namespace Decorator.Menus
{
    public interface IMenuItem
    {
        Guid Id { get; }
        string Name { get; }
        double Price { get; }
        bool IsSpecial { get; }
    }
}