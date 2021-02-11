using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"{Name}: {Price:C}";
        }
    }
}
