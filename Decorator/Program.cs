using Decorator.Menus;
using System;
using System.Collections.Generic;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuBuilder menuBuilder = new MenuBuilder(new List<IMenuItem>
            {
                new MenuItem("Chicken Sandwich", 6.99),
                new MenuItem("Pizza", 3.99),
                new MenuItem("Salad", 4.99),
            });

            IMenu menu = menuBuilder
                .WithDiscounts(50)
                .WithDailySpecial(new MenuItem("Milk", 0.99, true))
                .Build();

            foreach (IMenuItem item in menu.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
