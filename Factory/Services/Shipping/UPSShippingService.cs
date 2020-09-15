using System;

namespace Factory.Services.Shipping
{
    public class UPSShippingService : IShippingService
    {
        public void ProcessOrder(string buyerName, string itemName)
        {
            Console.WriteLine($"Processing order from {buyerName} for 1 {itemName} through UPS shipping.");
        }
    }
}