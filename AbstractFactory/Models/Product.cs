using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Name, -20} | {Price, 8:C}";
        }
    }
}
