using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.BookPublishers
{
    public interface IBookPublisher
    {
        void Publish(IEnumerable<string> bookContent);
    }
}
