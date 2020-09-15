using System;
using System.Threading;
using Factory.Services.Accelerators;
using Factory.Services.Payment;
using Factory.Services.Shipping;

namespace Factory.Models.OnlineStores
{
    public class FastOnlineStore : IOnlineStore
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;
        private readonly OrderAccelerationService _accelerationService;

        public string Name { get; }

        public FastOnlineStore(string name, IPaymentService paymentService, IShippingService shippingService,
            OrderAccelerationService accelerationService)
        {
            Name = name;
            _paymentService = paymentService;
            _shippingService = shippingService;
            _accelerationService = accelerationService;
        }

        public void OrderItem(string buyerName, string itemName)
        {
            Console.WriteLine($"'{Name}' received an order!");

            _accelerationService.AccelerateOrder();

            Console.WriteLine("Rapidly verifying order.");

            _paymentService.ProcessPayment(buyerName);

            _shippingService.ProcessOrder(buyerName, itemName);

            Console.WriteLine("Order complete.");
        }
    }
}