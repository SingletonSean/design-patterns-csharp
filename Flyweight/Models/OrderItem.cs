namespace Flyweight.Models
{
    public enum ProductType
    {
        CPU,
        Memory,
        Motherboard,
        GPU,
        PowerSupply,
        Storage
    }

    public class OrderItem
    {
        public Product Product { get; set; }
        public double Quantity { get; set; }

        public OrderItem(Product product, double quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
