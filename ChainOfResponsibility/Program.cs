using ChainOfResponsibility.Handlers.CreateProduct;
using ChainOfResponsibility.Handlers.DisplayAllProducts;
using ChainOfResponsibility.Services;
using ChainOfResponsibility.Stores;

// Services
ProductRepository productRepository = new ProductRepository();
AuthenticationStore authenticationStore = new AuthenticationStore();

// Handlers
CreateProductHandler createProductHandler = new CreateProductHandler(productRepository, authenticationStore);
ListProductsHandler listProductsHandler = new ListProductsHandler(productRepository, authenticationStore);

authenticationStore.SignIn();

bool hasExited = false;

do
{
    Console.Write("Enter a command: ");
    string command = Console.ReadLine() ?? "";
    string[] arguments = command.Split(" ");

    string action = arguments[0];
    string[] remainingArguments = arguments.Skip(1).ToArray();

    switch (action.ToLower())
    {
        case "list":
            listProductsHandler.Handle(remainingArguments);
            break;
        case "create":
            createProductHandler.Handle(remainingArguments);
            break;
        case "exit":
            hasExited = true;
            break;
        default:
            Console.WriteLine("Invalid command.");
            break;
    }
} while (!hasExited);

