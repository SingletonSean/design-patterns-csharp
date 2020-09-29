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
        private readonly IProductCommunicatorAbstractFactory _productCommunicatorAbstractFactory;

        public ProductService(IProductCommunicatorAbstractFactory productCommunicatorAbstractFactory)
        {
            _productCommunicatorAbstractFactory = productCommunicatorAbstractFactory;
        }

        public Product GetById(Guid id)
        {
            using (IProductReader reader = _productCommunicatorAbstractFactory.CreateProductReader())
            {
                return reader.GetById(id);
            }
        }

        public Product Save(Product product)
        {
            using (IProductWriter writer = _productCommunicatorAbstractFactory.CreateProductWriter())
            {
                return writer.Save(product);
            }
        }
    }
}
