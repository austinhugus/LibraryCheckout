using System;
using System.Collections.Generic;

namespace libraryCheckout.App.Models {
    public class Books : Publications {
        public Books (int pagecount, string genre, string title, string author, string description, int inStock) : base (title, author, description, inStock) {
            Pagecount = pagecount;
            Genre = genre;
        }

        public int Pagecount { get; set; }
        public string Genre { get; set; }

    }
}