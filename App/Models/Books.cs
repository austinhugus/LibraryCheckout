using System.Collections;

namespace libraryCheckout.App.Models {
    public class Books : Publications {
        public Books (int pagecount, string genre, string title, string author, string description, bool available) : base (title, author, description, available) {
            Pagecount = pagecount;
            Genre = genre;

        }

        public int Pagecount { get; set; }
        public string Genre { get; set; }

    }
}