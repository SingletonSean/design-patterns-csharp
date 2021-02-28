using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.BookPublishers
{
    public class AudioBookPublisher : IBookPublisher
    {
        public void Publish(IEnumerable<string> bookContent)
        {
            Console.WriteLine($"Successfully uploaded book to Audible. ({bookContent.Count()} lines)");
        }
    }
}
