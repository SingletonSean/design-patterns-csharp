using Decorator.Menus;
using System;
using System.Collections.Generic;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new Menu(new List<IMenuItem>
            {
                new MenuItem("Chicken Sandwich", 6.99),
                new MenuItem("Pizza", 3.99),
                new MenuItem("Salad", 4.99),
            });

            foreach (IMenuItem item in menu.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
