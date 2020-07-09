using System;
using libraryCheckout.App.Models;

namespace library {
    public class App {
        public Library Library { get; set; }
        public bool Running { get; private set; }
        public void Run () {
            Console.Clear ();
            Library = new Library ("Codeworks", "Austins Library");
            Console.WriteLine ("$/nI Hope You Enjoy Your Time At {Library.Location} in {Library.Name}");
            Running = true;
            while (Running) {
                Console.WriteLine ("What do you want to checkout?");
                string input = Console.ReadLine ().ToLower ();
                switch (input) {
                    case "b":
                        Checkout ();
                        break;
                        // case "m":
                        //     MagazineCheckout ();
                        //     break;
                    case "l":
                        Console.Clear ();
                        Console.WriteLine ("Come Back Soon!");
                        Running = false;
                        break;
                }
                void Checkout () {
                    Console.Clear ();
                    Library.ViewBooks ();
                    Console.WriteLine ("Here is out selection");
                    string selection = Console.ReadLine ();
                    Books selectedBook = Library.checkAvailability (selection);
                    if (selectedBook == null) {
                        Console.WriteLine ("Can't pick that one!");
                        return;
                    }
                    Console.WriteLine ($"Be Sure to return {selectedBook.Title} in two weeks! (Y/N)");
                    string input = Console.ReadLine ();
                    switch (input) {
                        case "y":
                            int quantity;
                            string checkedOutBook = "1";
                            bool valid = Int32.TryParse (checkedOutBook, out quantity);

                            if (selectedBook.InStock >= quantity) {
                                selectedBook.InStock -= quantity;
                                Console.WriteLine ($"Enjoy {selectedBook.Title}");
                                return;
                            }
                            break;

                            // void MagazineCheckout () {
                            //     Console.Clear ();
                            //     Console.WriteLine ("Do you want to see our magazines?");
                            //     Library.ViewMagazines ();
                            //     Console.WriteLine ("Choose a Magazine");
                            //     Console.ReadLine ();
                            //     Console.Clear ();
                            //     Console.WriteLine ("Unfortunately you can't check these out");
                            // }
                    }
                }
            }
        }

    }
}