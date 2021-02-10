using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services.ProductRepositories
{
    public class InMemoryProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public InMemoryProductRepository()
        {
            _products = new List<Product>();
        }

        public Task Create(Product product)
        {
            product.Id = Guid.NewGuid();

            _products.Add(product);

            return Task.CompletedTask;
        }

        public Task<Product> GetById(Guid productId)
        {
            Product product = _products.FirstOrDefault(p => p.Id == productId);

            return Task.FromResult(product);
        }
    }
}
