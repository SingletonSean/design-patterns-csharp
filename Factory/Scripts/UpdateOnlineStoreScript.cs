using System;
using Factory.Models.OnlineStores;
using Factory.Services.Payment;
using Factory.Services.Shipping;

namespace Factory.Scripts
{
    public class UpdateOnlineStoreScript
    {
        private readonly IOnlineStoreFactory _onlineStoreFactory;

        public UpdateOnlineStoreScript(IOnlineStoreFactory onlineStoreFactory)
        {
            _onlineStoreFactory = onlineStoreFactory;
        }

        public IOnlineStore Run()
        {
            Console.Write("Enter your updated online store's name: ");
            string storeName = Console.ReadLine();

            IOnlineStore store = _onlineStoreFactory.CreateOnlineStore(storeName);

            return store;
        }
    }
}