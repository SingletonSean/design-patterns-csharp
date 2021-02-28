using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.BookContentProviders
{
    public class AutobiographyBookContentProvider : IBookContentProvider
    {
        public IEnumerable<string> GetContent()
        {
            return new List<string>()
            {
                "I was born.",
                "I learned to program.",
                "I became a YouTuber."
            };
        }
    }
}
