using AbstractFactory.Services.ProductReaders;
using AbstractFactory.Services.ProductWriters;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Services
{
    public class InMemoryProductCommunicatorAbstractFactory : IProductCommunicatorAbstractFactory
    {
        public IProductReader CreateProductReader()
        {
            return new InMemoryProductReader();
        }

        public IProductWriter CreateProductWriter()
        {
            return new InMemoryProductWriter();
        }
    }
}
