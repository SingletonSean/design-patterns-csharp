using Proxy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Services
{
    public class CachingBlogPostService : IBlogPostService
    {
        private readonly IBlogPostService _blogPostService;
        private readonly Lazy<Task<IEnumerable<BlogPost>>> _getAllLazy;

        public CachingBlogPostService(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
            _getAllLazy = new Lazy<Task<IEnumerable<BlogPost>>>(_blogPostService.GetAll);
        }

        public async Task<IEnumerable<BlogPost>> GetAll()
        {
            return await _getAllLazy.Value;
        }
    }
}
