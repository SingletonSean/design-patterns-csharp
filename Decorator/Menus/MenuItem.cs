using System;

namespace Decorator.Menus
{
    public class MenuItem : IMenuItem
    {
        public string Name { get; }
        public double Price { get; }
        public bool IsSpecial { get; }

        public MenuItem(string name, double price, bool isSpecial = false)
        {
            Name = name;
            Price = price;
            IsSpecial = isSpecial;
        }

        public override string ToString()
        {
            string specialDisplay = IsSpecial ? "-=- SPECIAL -=- " : string.Empty;
            return $"{specialDisplay}{Name}: {Price:C}";
        }
    }
}