using ChainOfResponsibility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Services
{
    public class ProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>();
        }

        public IEnumerable<Product> GetAll()
        {
            Thread.Sleep(3000);

            return _products;
        }

        public void Create(Product product)
        {
            Thread.Sleep(3000);

            _products.Add(product);
        }
    }
}
