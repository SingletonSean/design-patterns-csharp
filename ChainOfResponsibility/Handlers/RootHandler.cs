using ChainOfResponsibility.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class RootHandler : IHandler
    {
        private readonly IHandler _listProductsHandler;
        private readonly IHandler _createProductHandler;
        private readonly IHandler _exitHandler;
        private readonly AuthenticationStore _authenticationStore;

        public RootHandler(
            IHandler listProductsHandler,
            IHandler createProductHandler,
            IHandler exitHandler,
            AuthenticationStore authenticationStore)
        {
            _listProductsHandler = listProductsHandler;
            _createProductHandler = createProductHandler;
            _exitHandler = exitHandler;
            _authenticationStore = authenticationStore;
        }

        public void Handle(string[] args)
        {
            string action = args[0];
            string[] remainingArguments = args.Skip(1).ToArray();

            switch (action.ToLower())
            {
                case "list":
                    _listProductsHandler.Handle(remainingArguments);
                    break;
                case "create":
                    _createProductHandler.Handle(remainingArguments);
                    break;
                case "signin":
                    _authenticationStore.SignIn();
                    Console.WriteLine("Successfully signed in.");
                    break;
                case "signout":
                    _authenticationStore.SignOut();
                    Console.WriteLine("Successfully signed out.");
                    break;
                case "exit":
                    _exitHandler.Handle(remainingArguments);
                    break;
                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }
        }
    }
}
