using Mediator.Mediators;
using Mediator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Scripts
{
    public class NewestUserScript : IDisposable
    {
        private readonly UserMediator _userMediator;

        public User NewestUser { get; set; }

        public NewestUserScript(UserMediator userMediator)
        {
            _userMediator = userMediator;

            _userMediator.UserCreated += UserMediator_UserCreated;
        }

        public void Run()
        {
            Console.WriteLine();

            Console.WriteLine("NEWEST USER");
            Console.WriteLine(NewestUser);

            Console.WriteLine();
        }

        public void Dispose()
        {
            _userMediator.UserCreated -= UserMediator_UserCreated;
        }

        private void UserMediator_UserCreated(User newUser)
        {
            NewestUser = newUser;

            Run();
        }
    }
}
