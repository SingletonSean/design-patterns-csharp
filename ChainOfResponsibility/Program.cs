using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Handlers.CreateProduct;
using ChainOfResponsibility.Handlers.ListProducts;
using ChainOfResponsibility.Services;
using ChainOfResponsibility.Stores;

// Services
ProductRepository productRepository = new ProductRepository();
AuthenticationStore authenticationStore = new AuthenticationStore();
ApplicationStore applicationStore = new ApplicationStore();

// Handlers
IHandler createProductHandler = new AuthenticationHandler(authenticationStore, new CreateProductHandler(productRepository));
IHandler listProductsHandler = new AuthenticationHandler(authenticationStore, new ListProductsHandler(productRepository));
IHandler exitHandler = new ExitHandler(applicationStore);
IHandler rootHandler = new RootHandler(listProductsHandler, createProductHandler, exitHandler, authenticationStore);

do
{
    Console.Write("Enter a command: ");

    string command = Console.ReadLine() ?? "";
    string[] arguments = command.Split(" ");

    rootHandler.Handle(arguments);
} while (!applicationStore.HasExited);

