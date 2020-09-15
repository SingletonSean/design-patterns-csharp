using System;
using Factory.Models.OnlineStores;
using Factory.Scripts;
using Factory.Services.Payment;
using Factory.Services.Shipping;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup dependencies.
            IPaymentService paymentService = new BasicPaymentService();
            IShippingService shippingService = new FedexShippingService();

            // Setup scripts.
            CreateOnlineStoreScript createScript = new CreateOnlineStoreScript(paymentService, shippingService);
            UpdateOnlineStoreScript updateScript = new UpdateOnlineStoreScript(paymentService, shippingService);

            // Execute create script.
            IOnlineStore store = createScript.Run();
            store.OrderItem("Sean", "Motherboard");

            // Execute update script.
            store = updateScript.Run();
            store.OrderItem("Sean", "CPU");
        }
    }
}
