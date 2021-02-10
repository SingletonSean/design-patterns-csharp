using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services.ProductRepositories
{
    public interface IProductRepository
    {
        Task<Product> GetById(Guid productId);
        Task Create(Product product);
    }
}
