using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace AbstractFactory.Services.ProductWriters
{
    public class FileProductWriter : IDisposable, IProductWriter
    {
        private readonly ICollection<Product> _products;

        private bool _disposed;

        public FileProductWriter(string fileName)
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

        public Product Save(Product product)
        {
            if (_disposed)
            {
                throw new Exception("Object is disposed.");
            }

            product.Id = Guid.NewGuid();

            _products.Add(product);

            string productsJson = JsonSerializer.Serialize(_products);
            File.WriteAllText("products.json", productsJson);

            return product;
        }

        public void Dispose()
        {
            _disposed = true;
            _products.Clear();
        }
    }
}
