using System;
using System.Collections.Generic;
using System.Threading;
using libraryCheckout;
using libraryCheckout.App.Models;

namespace libraryCheckout {
    public class Application {

        public Application (Library library, bool running) {
            this.Library = library;
            this.Running = running;

        }
        public Library Library { get; set; }
        public bool Running { get; set; }

        public void Run () {
            Console.Clear ();

        }

    }
}