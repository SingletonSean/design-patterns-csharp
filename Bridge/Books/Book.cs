using Bridge.BookContentProviders;
using Bridge.BookPublishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge.Books
{
    public class Book : IBook
    {
        private readonly IBookContentProvider _contentProvider;
        private readonly IBookPublisher _publisher;

        public Book(IBookContentProvider contentProvider, IBookPublisher publisher)
        {
            _contentProvider = contentProvider;
            _publisher = publisher;
        }

        public void Publish()
        {
            IEnumerable<string> bookContent = _contentProvider.GetContent();

            Console.WriteLine("Saved book content to database.");

            _publisher.Publish(bookContent);
        }
    }
}
