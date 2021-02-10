using Adapter.Models;
using Adapter.Services.ProductRepositories;
using System;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IProductRepository productRepository = new InMemoryProductRepository();

            await Run(productRepository);
        }

        private static async Task Run(IProductRepository productRepository)
        {
            Product product = new Product()
            {
                Name = "Shoes",
                Price = 129.99
            };

            await productRepository.Create(product);

            Product savedProduct = await productRepository.GetById(product.Id);

            Console.WriteLine($"{savedProduct.Name}: {savedProduct.Price:C}");
        }
    }
}
