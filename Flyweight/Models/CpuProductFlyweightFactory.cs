using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Models
{
    public class CpuProductFlyweightFactory
    {
        private readonly Dictionary<CpuSeries, Product> _cpuSeriesToProduct;

        public CpuProductFlyweightFactory()
        {
            _cpuSeriesToProduct = new Dictionary<CpuSeries, Product>();
        }

        public Product Create(CpuSeries series)
        {
            if(!_cpuSeriesToProduct.ContainsKey(series))
            {
                switch (series)
                {
                    case CpuSeries.IntelCoreI9:
                        _cpuSeriesToProduct.Add(series, new Product("Intel Core i9", "A powerful Intel CPU.", ProductType.CPU, 500));
                        break;
                    case CpuSeries.IntelCoreI7:
                        _cpuSeriesToProduct.Add(series, new Product("Intel Core i7", "An Intel CPU.", ProductType.CPU, 300));
                        break;
                    case CpuSeries.AmdRyzen7:
                        _cpuSeriesToProduct.Add(series, new Product("AMD Ryzen 7", "A powerful AMD CPU.", ProductType.CPU, 300));
                        break;
                    case CpuSeries.AmdRyzen5:
                        _cpuSeriesToProduct.Add(series, new Product("AMD Ryzen 5", "An AMD CPU.", ProductType.CPU, 200));
                        break;
                    default:
                        throw new Exception("Unknown CPU series.");
                }
            }

            return _cpuSeriesToProduct[series];
        }
    }
}
