using Mediator.Mediators;
using Mediator.Models;

namespace Mediator.Scripts
{
    public class SignUpScript
    {
        private readonly UserMediator _userMediator;

        public SignUpScript(UserMediator userMediator)
        {
            _userMediator = userMediator;
        }

        public void Run()
        {
            Console.Write("Email: ");
            string email = Console.ReadLine()!;

            User newUser = new User(email);
            _userMediator.Create(newUser);

            Console.WriteLine("Successfully signed up.");
        }
    }
}
