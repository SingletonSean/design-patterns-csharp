using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services.ProductWriters
{
    public interface IProductWriter
    {
        Task WriteProduct(Product product);
    }
}
