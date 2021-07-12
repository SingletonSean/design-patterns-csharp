using Proxy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proxy.Services
{
    public interface IBlogPostService
    {
        Task<IEnumerable<BlogPost>> GetAll();
    }
}