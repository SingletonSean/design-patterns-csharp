using AbstractFactory.Models;
using AbstractFactory.Services.ProductReaders;
using AbstractFactory.Services.ProductWriters;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Services
{
    public class ProductService
    {
        private const string FILE_NAME = "products.json";

        public Product GetById(Guid id)
        {
            using (FileProductReader reader = new FileProductReader(FILE_NAME))
            {
                return reader.GetById(id);
            }
        }

        public Product Save(Product product)
        {
            using (FileProductWriter writer = new FileProductWriter(FILE_NAME))
            {
                return writer.Save(product);
            }
        }
    }
}
