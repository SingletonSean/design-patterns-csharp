using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Models
{
    public class Product
    {
        public string Description { get; }
        public decimal Price { get; }

        public Product(string description, decimal price)
        {
            Description = description;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Description}: {Price:C}";
        }
    }
}
