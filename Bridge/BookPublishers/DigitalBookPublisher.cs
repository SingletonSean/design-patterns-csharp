using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.BookPublishers
{
    public class DigitalBookPublisher : IBookPublisher
    {
        public void Publish(IEnumerable<string> bookContent)
        {
            Console.WriteLine($"Successfully uploaded book to Amazon. ({bookContent.Count()} lines)");
        }
    }
}
