using Proxy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Services
{
    public class ConsoleLoggingBlogPostService : IBlogPostService
    {
        private readonly IBlogPostService _blogPostService;

        public ConsoleLoggingBlogPostService(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
        }

        public async Task<IEnumerable<BlogPost>> GetAll()
        {
            Console.WriteLine("Getting all blog posts.");

            IEnumerable<BlogPost> blogPosts = await _blogPostService.GetAll();

            Console.WriteLine("Successfully retrieved all blog posts.");

            return blogPosts;
        }
    }
}
