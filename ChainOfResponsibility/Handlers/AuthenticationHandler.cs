using ChainOfResponsibility.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class AuthenticationHandler : IHandler
    {
        private readonly AuthenticationStore _authenticationStore;
        private readonly IHandler _nextHandler;

        public AuthenticationHandler(AuthenticationStore authenticationStore, IHandler nextHandler)
        {
            _authenticationStore = authenticationStore;
            _nextHandler = nextHandler;
        }

        public void Handle(string[] args)
        {
            if (!_authenticationStore.IsSignedIn)
            {
                Console.WriteLine("You must be signed in to perform this operation.");
                return;
            }

            _nextHandler.Handle(args);
        }
    }
}
