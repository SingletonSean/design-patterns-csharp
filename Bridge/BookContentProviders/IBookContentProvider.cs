using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.BookContentProviders
{
    public interface IBookContentProvider
    {
        IEnumerable<string> GetContent();
    }
}
