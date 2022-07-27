using Mediator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Mediators
{
    public class UserMediator
    {
        private readonly List<User> _users;

        public IEnumerable<User> Users => _users;

        public event Action<User> UserCreated;

        public UserMediator()
        {
            _users = new List<User>();
        }

        public void Create(User user)
        {
            _users.Add(user);

            UserCreated?.Invoke(user);
        }
    }
}
