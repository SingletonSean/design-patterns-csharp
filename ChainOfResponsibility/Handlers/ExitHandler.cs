using ChainOfResponsibility.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Handlers
{
    public class ExitHandler : IHandler
    {
        private readonly ApplicationStore _applicationStore;

        public ExitHandler(ApplicationStore applicationStore)
        {
            _applicationStore = applicationStore;
        }

        public void Handle(string[] args)
        {
            Console.WriteLine("Exiting application.");
            _applicationStore.Exit();
        }
    }
}
