namespace Factory.Models.OnlineStores
{
    public interface IOnlineStoreFactory
    {
        IOnlineStore CreateOnlineStore(string name);
    }
}