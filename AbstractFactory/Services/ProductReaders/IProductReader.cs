using AbstractFactory.Models;
using System;

namespace AbstractFactory.Services.ProductReaders
{
    public interface IProductReader : IDisposable
    {
        Product GetById(Guid id);
    }
}