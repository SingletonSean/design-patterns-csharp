namespace Factory.Services.Shipping
{
    public interface IShippingService
    {
        void ProcessOrder(string buyerName, string itemName);
    }
}