using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryBooks
{
    public class Book
    {
        public string Title { get; set; }

        public string PageCount { get; set; }

        public int CurrentPage { get; set; }

        public List<int> BookMarkPages = new List<int>(5);

    }
}
