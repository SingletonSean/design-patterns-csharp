using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AbstractFactory.Services.ProductReaders
{
    public class FileProductReader : IDisposable, IProductReader
    {
        private readonly ICollection<Product> _products;

        private bool _disposed;

        public FileProductReader(string fileName)
        {
            try
            {
                string productsJson = File.ReadAllText(fileName);
                _products = JsonSerializer.Deserialize<ICollection<Product>>(productsJson);
            }
            catch (FileNotFoundException)
            {
                _products = new List<Product>();
            }
        }

        public Product GetById(Guid id)
        {
            if (_disposed)
            {
                throw new Exception("Object is disposed.");
            }

            Product product = _products.FirstOrDefault(p => p.Id == id);

            bool productNotFound = product == null;
            if (productNotFound)
            {
                throw new Exception("Product not found.");
            }

            return product;
        }

        public void Dispose()
        {
            _disposed = true;
            _products.Clear();
        }
    }
}
