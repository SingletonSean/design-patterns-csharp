using ChainOfResponsibility.Models;
using ChainOfResponsibility.Services;
using ChainOfResponsibility.Stores;

namespace ChainOfResponsibility.Handlers.ListProducts
{
    public class ListProductsHandler : IHandler
    {
        private readonly ProductRepository _productRepository;

        public ListProductsHandler(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Handle(string[] args)
        {
            Console.WriteLine("Getting products...");

            IEnumerable<Product> products = _productRepository.GetAll();

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine($"Total Products: {products.Count()}");
        }
    }
}
