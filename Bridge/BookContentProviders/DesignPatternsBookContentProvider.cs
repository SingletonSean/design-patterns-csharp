using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.BookContentProviders
{
    public class DesignPatternsBookContentProvider : IBookContentProvider
    {
        public IEnumerable<string> GetContent()
        {
            return new List<string>
            {
                "The bridge pattern is awesome."
            };
        }
    }
}
