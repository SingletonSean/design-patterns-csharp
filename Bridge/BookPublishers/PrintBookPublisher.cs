using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.BookPublishers
{
    public class PrintBookPublisher : IBookPublisher
    {
        public void Publish(IEnumerable<string> bookContent)
        {
            Console.WriteLine($"Successfully printed book. ({bookContent.Count()} lines)");
        }
    }
}
