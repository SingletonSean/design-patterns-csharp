using ChainOfResponsibility.Models;
using ChainOfResponsibility.Services;
using ChainOfResponsibility.Stores;

namespace ChainOfResponsibility.Handlers.DisplayAllProducts
{
    public class ListProductsHandler
    {
        private readonly ProductRepository _productRepository;
        private readonly AuthenticationStore _authenticationStore;

        public ListProductsHandler(ProductRepository productRepository, AuthenticationStore authenticationStore)
        {
            _productRepository = productRepository;
            _authenticationStore = authenticationStore;
        }

        public void Handle(string[] args)
        {
            if (!_authenticationStore.IsSignedIn)
            {
                Console.WriteLine("You must be signed in to view products.");
                return;
            }

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
