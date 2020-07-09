using System;
using System.Collections.Generic;

namespace libraryCheckout.App.Models {
    public class Library {
        public string Name { get; set; }
        public string Location { get; set; }

        public List<Books> Books { get; set; } = new List<Books> ();
        public List<Magazine> Magazines { get; set; } = new List<Magazine> ();
        public Library (string location, string name) {
            Location = location;
            Name = name;

            Books.Add (new Books (150, "horror", "Dracula", "Bram Stroker", "Weird dude really likes blood", 10));
            Books.Add (new Books (100, "science", "Honey I Shrunk The Kid", "ScienceGuy", "Guy Cant be left with the kids for more than an hour", 10));
            Books.Add (new Books (200, "suspense", "I Know What You Did Last Summer", "Lois Duncan", "Guy gets murdered...or did he?", 8));
            Books.Add (new Books (175, "boring", "The Notebook", "Nicolas Sparks", "It rains at somepoint in the book", 15));
            Books.Add (new Books (900, "thriller", "Where The Red Fern Grows", "Wilson Rawls", "Fun book about dogs", 20));

        }

        public void ViewBooks () {
            Console.WriteLine ("This is what we have to checkout");
            for (int i = 0; i < Books.Count; i++) {
                Books books = Books[i];
                if (books.Available) {
                    Console.WriteLine ($"{i+1}. {books.Title} ");
                }
            }
        }
        public void ViewBooks (bool Available) {
            Console.WriteLine ("Book Stock");
            ConsoleColor forecolor = Console.ForegroundColor;
            for (int i = 0; i < Books.Count; i++) {
                Books books = Books[i];
                if (books.Available == Available) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine ($"{i + 1}. {books.Title} by {books.Author} x {books.InStock}");
                } else {
                    Console.ForegroundColor = forecolor;
                    Console.WriteLine ($"{i + 1}. {books.Title} by {books.Author} x {books.Available}");

                }
            }
            Console.ForegroundColor = forecolor;
        }
        internal Books checkAvailability (string selection) {
            int bookIndex;
            bool valid = Int32.TryParse (selection, out bookIndex);
            if (!valid || bookIndex < 1 || bookIndex > Books.Count) {
                return null;
            }
            return Books[bookIndex - 1];
        }
    }
}