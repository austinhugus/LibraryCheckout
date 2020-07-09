using System;
using System.Collections.Generic;
using libraryCheckout.App.Models;

namespace libraryCheckout.App.Models {
    public abstract class Publications {
        public Publications (string title, string author, string description, int inStock) {
            Title = title;
            Author = author;
            Description = description;
            InStock = inStock;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int InStock { get; set; }
        public bool Available { get { return InStock > 0; } }

    }
}