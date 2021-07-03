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
        private readonly CpuProductFlyweightFactory _cpuProductFactory;

        public CpuOrderItemFactory(CpuProductFlyweightFactory cpuProductFactory)
        {
            _cpuProductFactory = cpuProductFactory;
        }

        public OrderItem Create(CpuSeries series, int quantity)
        {
            Product cpuProduct = _cpuProductFactory.Create(series);

            return new OrderItem(cpuProduct, quantity);
        }
    }
}
