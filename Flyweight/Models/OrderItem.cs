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
        public string Name { get; set; }
        public string Description { get; set; }
        public ProductType Type { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public OrderItem(string name, string description, ProductType type, double price, double quantity)
        {
            Name = name;
            Description = description;
            Type = type;
            Price = price;
            Quantity = quantity;
        }
    }
}
