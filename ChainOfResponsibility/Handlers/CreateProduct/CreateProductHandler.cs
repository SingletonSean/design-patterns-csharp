using ChainOfResponsibility.Models;
using ChainOfResponsibility.Services;
using ChainOfResponsibility.Stores;

namespace ChainOfResponsibility.Handlers.CreateProduct
{
    public class CreateProductHandler
    {
        private readonly ProductRepository _productRepository;
        private readonly AuthenticationStore _authenticationStore;

        public CreateProductHandler(ProductRepository productRepository, AuthenticationStore authenticationStore)
        {
            _productRepository = productRepository;
            _authenticationStore = authenticationStore;
        }

        public void Handle(string[] args)
        {
            if(!_authenticationStore.IsSignedIn)
            {
                Console.WriteLine("You must be signed in to create a product.");
                return;
            }

            if(args.Length < 2)
            {
                Console.WriteLine("Invalid parameters. Please provide a description and price.");
                return;
            }

            string description = args[0];
            if (!decimal.TryParse(args[1], out decimal price))
            {
                Console.WriteLine($"Invalid price: {args[1]}");
                return;
            };

            Console.WriteLine("Creating product...");

            Product product = new Product(description, price);
            _productRepository.Create(product);

            Console.WriteLine($"Successfully created product '{product}'.");
        }
    }
}
