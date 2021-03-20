using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Menus
{
    public class DiscountMenuItem : MenuItem
    {
        private readonly double _discountPercentage;

        public override double Price => base.Price * (_discountPercentage / 100);

        public DiscountMenuItem(string name, double price, double discountPercentage, bool isSpecial = false) 
            : base(name, price, isSpecial)
        {
            _discountPercentage = discountPercentage;
        }
    }
}
