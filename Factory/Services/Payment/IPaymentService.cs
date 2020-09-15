namespace Factory.Services.Payment
{
    public interface IPaymentService
    {
        void ProcessPayment(string buyerName);
    }
}