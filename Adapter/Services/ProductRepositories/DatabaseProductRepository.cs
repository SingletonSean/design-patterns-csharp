using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Services.ProductRepositories
{
    public class DatabaseProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;

        public DatabaseProductRepository(ProductDbContext context)
        {
            _context = context;
        }

        public async Task Create(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetById(Guid productId)
        {
            return await _context.Products.FindAsync(productId);
        }
    }
}
