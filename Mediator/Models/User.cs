namespace Mediator.Models
{
    public class User
    {
        public string Email { get; }

        public User(string email)
        {
            Email = email;
        }

        public override string ToString()
        {
            return Email;
        }
    }
}
