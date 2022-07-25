using Mediator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Scripts
{
    public class ListUsersScript
    {
        private readonly List<User> _users;

        public ListUsersScript()
        {
            _users = new List<User>();
        }

        public void Run()
        {
            Console.WriteLine();

            Console.WriteLine("USERS");
            foreach (User user in _users)
            {
                Console.WriteLine(user);
            }
            
            Console.WriteLine();
        }

        public void AddUser(User newUser)
        {
            _users.Add(newUser);
        }
    }
}
