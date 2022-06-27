namespace ChainOfResponsibility.Stores
{
    public class AuthenticationStore
    {
        public bool IsSignedIn { get; private set; }

        public void SignIn()
        {
            IsSignedIn = true;
        }
    }
}
