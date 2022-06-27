using ChainOfResponsibility.Models;
using ChainOfResponsibility.Services;
using ChainOfResponsibility.Stores;

namespace ChainOfResponsibility.Handlers.CreateProduct
{
    public class CreateProductHandler : IHandler
    {
        private readonly ProductRepository _productRepository;

        public CreateProductHandler(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Handle(string[] args)
        {
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
