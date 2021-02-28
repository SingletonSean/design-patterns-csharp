using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.Books
{
    public abstract class DigitalBook : IBook
    {
        public void Publish()
        {
            IEnumerable<string> bookContent = GetBookContent();

            Console.WriteLine($"Successfully uploaded book to Amazon. (${bookContent.Count()} lines)");
        }

        protected abstract IEnumerable<string> GetBookContent();
    }
}
