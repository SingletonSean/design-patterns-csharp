using Bridge.BookContentProviders;
using Bridge.BookPublishers;
using Bridge.Books;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IBookContentProvider contentProvider = new DesignPatternsBookContentProvider();
            IBookPublisher publisher = new AudioBookPublisher();
            Book book = new Book(contentProvider, publisher);
            book.Publish();

            Console.ReadKey();
        }
    }
}
