using Adapter.Models;
using Adapter.Services;
using Adapter.Services.FileWriters;
using Adapter.Services.ProductRepositories;
using Adapter.Services.ProductWriters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static async Task Main(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseInMemoryDatabase("products").Options;
            ProductDbContext context = new ProductDbContext(options);
            IProductRepository productRepository = new DatabaseProductRepository(context);

            IProductWriter productWriter = new FileProductWriter(new FileWriter(), "products.txt");

            await Run(productRepository, productWriter);
        }

        private static async Task Run(IProductRepository productRepository, IProductWriter productWriter)
        {
            Product product = new Product()
            {
                Name = "Shoes",
                Price = 129.99
            };

            await productRepository.Create(product);

            Product savedProduct = await productRepository.GetById(product.Id);

            await productWriter.WriteProduct(savedProduct);
        }
    }
}
