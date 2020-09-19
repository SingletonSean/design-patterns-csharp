using Factory.Services.Accelerators;
using Factory.Services.Payment;
using Factory.Services.Shipping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models.OnlineStores
{
    public class FastOnlineStoreFactory : IOnlineStoreFactory
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;
        private readonly OrderAccelerationService _accelerationStore;

        public FastOnlineStoreFactory(IPaymentService paymentService, 
            IShippingService shippingService, 
            OrderAccelerationService accelerationStore)
        {
            _paymentService = paymentService;
            _shippingService = shippingService;
            _accelerationStore = accelerationStore;
        }

        public IOnlineStore CreateOnlineStore(string name)
        {
            return new FastOnlineStore(name, _paymentService, _shippingService, _accelerationStore);
        }
    }
}
