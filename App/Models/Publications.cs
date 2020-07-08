using System;

namespace libraryCheckout.App.Models {
    public abstract class Publications {
        public Publications (string title, string author, string description, bool available) {
            Title = title;
            Author = author;
            Description = description;
            Available = available;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public bool Available { get; set; }

        internal bool Start () {
            throw new NotImplementedException ();
        }
    }
}