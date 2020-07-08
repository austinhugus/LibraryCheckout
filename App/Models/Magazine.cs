namespace libraryCheckout.App.Models {
    public class Magazine : Publications {

        public Magazine (string subject, string category, string title, string author, string description, bool available) : base (title, author, description, available) {
            Subject = subject;
            Category = category;

        }
        public string Subject { get; set; }
        public string Category { get; set; }

    }

}