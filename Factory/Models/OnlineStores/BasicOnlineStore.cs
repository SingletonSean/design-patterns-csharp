using System;
using System.Threading;
using Factory.Services.Payment;
using Factory.Services.Shipping;

namespace Factory.Models.OnlineStores
{
    public class BasicOnlineStore : IOnlineStore
    {
        private readonly IPaymentService _paymentService;
        private readonly IShippingService _shippingService;

        public string Name { get; }

        public BasicOnlineStore(string name, IPaymentService paymentService, IShippingService shippingService)
        {
            Name = name;
            _paymentService = paymentService;
            _shippingService = shippingService;
        }

        public void OrderItem(string buyerName, string itemName)
        {
            Console.WriteLine($"'{Name}' received an order!");

            Console.WriteLine("Verifying order.");
            Thread.Sleep(500);

            _paymentService.ProcessPayment(buyerName);

            _shippingService.ProcessOrder(buyerName, itemName);

            Console.WriteLine("Order complete.");
        }
    }
}