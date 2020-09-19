using System;
using System.Net.Http.Headers;
using Factory.Models.OnlineStores;
using Factory.Scripts;
using Factory.Services.Accelerators;
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
            OrderAccelerationService accelerationService = new OrderAccelerationService();
            IOnlineStoreFactory onlineStoreFactory = new BasicOnlineStoreFactory(paymentService, shippingService);

            // Setup scripts.
            CreateOnlineStoreScript createScript = new CreateOnlineStoreScript(onlineStoreFactory);
            UpdateOnlineStoreScript updateScript = new UpdateOnlineStoreScript(onlineStoreFactory);

            // Execute create script.
            IOnlineStore store = createScript.Run();
            store.OrderItem("Sean", "Motherboard");

            // Execute update script.
            store = updateScript.Run();
            store.OrderItem("Sean", "CPU");
        }
    }
}
