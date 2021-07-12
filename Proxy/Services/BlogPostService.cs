using Proxy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Services
{
    public class BlogPostService : IBlogPostService
    {
        public async Task<IEnumerable<BlogPost>> GetAll()
        {
            await Task.Delay(1000);

            return new List<BlogPost>
            {
                new BlogPost
                {
                    Title = "Post 1",
                    Content = "This is the first post.",
                    DateCreated = DateTime.Now
                },
                new BlogPost
                {
                    Title = "Post 2",
                    Content = "This is the second post.",
                    DateCreated = DateTime.Now
                },
                new BlogPost
                {
                    Title = "Post 3",
                    Content = "This is the third post.",
                    DateCreated = DateTime.Now
                }
            };
        }
    }
}
