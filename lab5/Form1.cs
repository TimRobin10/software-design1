using Azure.Identity;
using Microsoft.EntityFrameworkCore;

namespace lab5
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }

    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listBookBox.DataSource = null;
            listBookBox.DataSource = GetAuthorsWithBook();
        }

        private void txtAuthorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBookTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var author = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            AddAuthorWithBook(author, bookTitle);

            var bookList = GetAuthorsWithBook();
            listBookBox.DataSource = null;
            listBookBox.DataSource = bookList;
        }

        private void listBookBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = context.Authors.FirstOrDefault(a => a.Name == authorName);

                if (author == null) // Avoid duplicate authors
                {
                    author = new Author { Name = authorName };
                    context.Authors.Add(author);
                }

                var book = new Book { Title = bookTitle, Author = author };
                context.Books.Add(book);

                context.SaveChanges();
            }

        }

        public List<string> GetAuthorsWithBook()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = context.Books
                .Include(book => book.Author)
                .Where(book => book.Author != null)
                .Select(book => $"Book ID: {book.BookID} | {book.Title} by {book.Author.Name}")
                .ToList();
                return booksWithAuthors;

            }
        }

        private void txtBookTitleUpdate_TextChanged(object sender, EventArgs e)
        {

        }

        public void updateBook(int bookID, string newTitle, string newAuthor)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.
                    Include(book => book.Author).
                    FirstOrDefault(book => book.BookID == bookID);

                if (book != null)
                {
                    if (!string.IsNullOrEmpty(newTitle) && !string.IsNullOrEmpty(newAuthor))
                    {
                        if (!string.IsNullOrEmpty(newAuthor))
                        {
                            book.Author.Name = newAuthor;
                        }

                        if (!string.IsNullOrEmpty(newTitle))
                        {
                            book.Title = newTitle;
                        }

                        context.SaveChanges();
                        MessageBox.Show("Book Information Updated!");
                        listBookBox.DataSource = null;
                        listBookBox.DataSource = GetAuthorsWithBook();
                    }
                    else
                    {
                        MessageBox.Show("No New Credentials. Database not Updated!");
                    }


                }
                else
                {
                    MessageBox.Show("Book not Found");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int bookID = int.Parse(txtBoxID.Text);
            updateBook(bookID, txtBookTitleUpdate.Text, txtAuthorNameUpdate.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBookIDDel.Text);
            deleteBook(id);
            listBookBox.DataSource = null;
            listBookBox.DataSource= GetAuthorsWithBook();
        }

        public void deleteBook(int idBook)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.FirstOrDefault(book => book.BookID == idBook);
                if (idBook != null)
                {
                    if(book != null)
                    {
                        context.Books.Remove(book);
                        context.SaveChanges();
                        MessageBox.Show("Book Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Book not Fouund");
                    }
                } else
                {
                    MessageBox.Show("Enter Book ID!");
                }
            }
        }
    }
}