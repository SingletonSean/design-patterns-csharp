using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.Books
{
    public abstract class PrintBook : IBook
    {
        public void Publish()
        {
            IEnumerable<string> bookContent = GetBookContent();

            Console.WriteLine($"Successfully printed book. (${bookContent.Count()} lines)");
        }

        protected abstract IEnumerable<string> GetBookContent();
    }
}
