namespace libraryCheckout.App.Models {
    public class Magazine : Publications {

        public Magazine (string subject, string edition, string title, string author, string description, int inStock) : base (title, author, description, inStock) {
            Subject = subject;
            Edition = edition;

        }
        public string Subject { get; set; }
        public string Edition { get; set; }

    }

}