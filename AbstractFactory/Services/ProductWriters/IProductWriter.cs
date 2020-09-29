using AbstractFactory.Models;
using System;

namespace AbstractFactory.Services.ProductWriters
{
    public interface IProductWriter : IDisposable
    {
        Product Save(Product product);
    }
}