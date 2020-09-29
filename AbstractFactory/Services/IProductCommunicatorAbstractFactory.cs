using AbstractFactory.Services.ProductReaders;
using AbstractFactory.Services.ProductWriters;

namespace AbstractFactory.Services
{
    public interface IProductCommunicatorAbstractFactory
    {
        IProductReader CreateProductReader();
        IProductWriter CreateProductWriter();
    }
}