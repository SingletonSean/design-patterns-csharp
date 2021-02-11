using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services.ProductWriters
{
    public class ConsoleProductWriter : IProductWriter
    {
        public Task WriteProduct(Product product)
        {
            Console.WriteLine(product.ToString());

            return Task.CompletedTask;
        }
    }
}
