using Factory.Services.Payment;
using Factory.Services.Shipping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models.OnlineStores
{
    public class BasicOnlineStoreFactory : IOnlineStoreFactory
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;

        public BasicOnlineStoreFactory(IPaymentService paymentService, IShippingService shippingService)
        {
            _paymentService = paymentService;
            _shippingService = shippingService;
        }

        public IOnlineStore CreateOnlineStore(string name)
        {
            return new BasicOnlineStore(name, _paymentService, _shippingService);
        }
    }
}
