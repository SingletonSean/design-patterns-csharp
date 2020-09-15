using System;
using Factory.Models.OnlineStores;
using Factory.Services.Payment;
using Factory.Services.Shipping;

namespace Factory.Scripts
{
    public class UpdateOnlineStoreScript
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;

        public UpdateOnlineStoreScript(IPaymentService paymentService, IShippingService shippingService)
        {
            _paymentService = paymentService;
            _shippingService = shippingService;
        }

        public IOnlineStore Run()
        {
            Console.Write("Enter your updated online store's name: ");
            string storeName = Console.ReadLine();

            IOnlineStore store = new BasicOnlineStore(storeName, _paymentService, _shippingService);

            return store;
        }
    }
}