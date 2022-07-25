using Mediator.Models;

namespace Mediator.Scripts
{
    public class SignUpScript
    {
        private readonly ListUsersScript _listUsersScript;

        public SignUpScript(ListUsersScript listUsersScript)
        {
            _listUsersScript = listUsersScript;
        }

        public void Run()
        {
            Console.Write("Email: ");
            string email = Console.ReadLine()!;

            User newUser = new User(email);
            _listUsersScript.AddUser(newUser);

            Console.WriteLine("Successfully signed up.");

            _listUsersScript.Run();
        }
    }
}
