using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Services.ProductWriters
{
    public class InMemoryProductWriter : IProductWriter
    {
        public void Dispose() { }

        public Product Save(Product product)
        {
            product.Id = Guid.NewGuid();
            return product;
        }
    }
}
