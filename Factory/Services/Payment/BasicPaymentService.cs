using System;

namespace Factory.Services.Payment
{
    public class BasicPaymentService : IPaymentService
    {
        public void ProcessPayment(string buyerName)
        {
            Console.WriteLine($"Processing payment for {buyerName}.");
        }
    }
}