using System;

namespace Flyweight.Models
{
    public enum CpuSeries
    {
        IntelCoreI9,
        IntelCoreI7,
        AmdRyzen7,
        AmdRyzen5
    }

    public class CpuOrderItemFactory
    {
        public OrderItem Create(CpuSeries series, int quantity)
        {
            switch (series)
            {
                case CpuSeries.IntelCoreI9:
                    return new OrderItem("Intel Core i9", "A powerful Intel CPU.", ProductType.CPU, 500, quantity);
                case CpuSeries.IntelCoreI7:
                    return new OrderItem("Intel Core i7", "An Intel CPU.", ProductType.CPU, 300, quantity);
                case CpuSeries.AmdRyzen7:
                    return new OrderItem("AMD Ryzen 7", "A powerful AMD CPU.", ProductType.CPU, 300, quantity);
                case CpuSeries.AmdRyzen5:
                    return new OrderItem("AMD Ryzen 5", "An AMD CPU.", ProductType.CPU, 200, quantity);
                default:
                    throw new Exception("Unknown CPU series.");
            }
        }
    }
}
