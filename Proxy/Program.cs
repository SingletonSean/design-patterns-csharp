using Proxy.Models;
using Proxy.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IBlogPostService blogPostService = new CachingBlogPostService(new ConsoleLoggingBlogPostService(new BlogPostService()));

            while (true)
            {
                Console.WriteLine("1: View Blog Posts");
                Console.WriteLine("9: Exit");
                ConsoleKey key = Console.ReadKey().Key;
                
                Console.WriteLine();

                if (key == ConsoleKey.D1)
                {
                    await ViewBlogPosts(blogPostService);
                }
                else if(key == ConsoleKey.D9)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid key.");
                }
            }
        }

        private static async Task ViewBlogPosts(IBlogPostService blogPostService)
        {
            IEnumerable<BlogPost> blogPosts = await blogPostService.GetAll();
            Print(blogPosts);
        }

        private static void Print(IEnumerable<BlogPost> blogPosts)
        {
            Console.WriteLine("------------------");
            Console.WriteLine();

            foreach (BlogPost blogPost in blogPosts)
            {
                Console.WriteLine(blogPost.Title);
                Console.WriteLine(blogPost.Content);
                Console.WriteLine();
            }

            Console.WriteLine("------------------");
        }
    }
}
