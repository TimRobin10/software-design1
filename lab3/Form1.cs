namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string? Title { get; set; }

            public string? Author { get; set; }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }

            public void validate()
            {
                if (string.IsNullOrWhiteSpace(Title))
                {
                    throw new ArgumentException("Title cannot be empty.");
                }
                if (string.IsNullOrEmpty(Author))
                {
                    throw new ArgumentException("Author cannot be empty.");
                }
            }
        }

        public class Magazine : Book
        {
            public int issueNumber { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - Issue {issueNumber}";
            }

            public void validate()
            {
                if (int.IsNegative(issueNumber))
                {
                    throw new ArgumentException("IssueNumber cannot be less than 0.");
                }
                if (string.IsNullOrEmpty(Title))
                {
                    throw new ArgumentException("Title cannot be empty.");
                }
            }
        }

        public class textBook : Book
        {
            public string? subject { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - Subject: {subject}";
            }

            public void validate()
            {
                if (string.IsNullOrEmpty(Title))
                {
                    throw new ArgumentException("Title cannot be empty.");
                }
                if (string.IsNullOrEmpty(subject))
                {
                    throw new ArgumentException("Subject cannot be empty.");
                }
            }
        }

        public class audioBook : Book
        {
            public int duration { get; set; }
            public string? narrator { get; set; }

            public override string GetInfo()
            {
                return $"{Title} - Narrated by {narrator} - Duration: {duration} minutes";
            }
        }

        public void loadBooks(List<Book> book, ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (var books in book)
            {
                listbox.Items.Add(books.GetInfo());
            }
        }
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>
            {
                new Book
                {
                    Title = "Harry Potter",
                    Author = "J.K Rowling"
                },
                new Magazine
                {
                    Title = "Time Magazine",
                    issueNumber = 234,
                },
                new textBook
                {
                    Title = "Life and Works of Rizal",
                    Author = "Rey Atacador"
                },
                new audioBook
                {
                    Title = "The Imitation Game",
                    narrator = "Alan Turing",
                    duration = 10
                }
            };

            loadBooks(books, bookListBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
