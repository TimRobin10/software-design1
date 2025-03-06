using lab5;

using Microsoft.EntityFrameworkCore;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async Task<List<string>> GetBooksAsync()
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                    .Include(b => b.Author)
                    .Select(b => $"Book ID: {b.BookID} | {b.Title} by {b.Author.Name}")
                    .ToListAsync();

                return books;
            }
        }

        public async Task SaveBookAsync(string bookTitle, string authroName)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authroName };
                var book = new Book { Title = bookTitle, Author = author };

                context.Books.Add(book);
                context.Authors.Add(author);

                await context.SaveChangesAsync();
            }
        }

        public async Task SearchBookTitleAsync(string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                    .Include(b => b.Author)
                    .Where(b => EF.Functions.Like(b.Title, $"%{bookTitle}%")) 
                    .Select(b => $"Book ID: {b.BookID} | {b.Title} by {b.Author.Name}")
                    .ToListAsync();

                if (books.Any())
                {
                    listBookBox.DataSource = null;
                    listBookBox.DataSource = books;
                }
                else
                {
                    MessageBox.Show("No books found with the given title.");
                }
            }
        }

        public async Task DeleteBook(int bookID)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books
                    .Include(b => b.Author)
                    .FirstOrDefault(book => book.BookID == bookID);

                if (bookID != null)
                {
                    if (book != null)
                    {
                        context.Books.Remove(book);
                        context.SaveChanges();
                        MessageBox.Show("Book Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Book not Fouund");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Book ID!");
                }
            }
        }

        public async Task UpdateBookAsync(int bookID, string newTitle, string newAuthor)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books
                    .Include(b => b.Author)
                    .FirstOrDefault(book => book.BookID == bookID);

                if (book != null)
                {
                    if (!string.IsNullOrEmpty(newTitle) || !string.IsNullOrEmpty(newAuthor))
                    {
                        if (!string.IsNullOrEmpty(newAuthor))
                        {
                            book.Author.Name = newAuthor;
                        }

                        if (!string.IsNullOrEmpty(newTitle))
                        {
                            book.Title = newTitle;
                        }

                        await context.SaveChangesAsync();
                        MessageBox.Show("Book Information Updated!");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var books = await GetBooksAsync();

            listBookBox.DataSource = books;
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookAsync(bookTitle, authorName);

            MessageBox.Show("Book and Author added Successfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int bookID = int.Parse(txtBoxUpdateID.Text);
            Task task = UpdateBookAsync(bookID, txtBoxUpdateTitle.Text, txtBoxUpdateAuthor.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBookIDDelete.Text);
            DeleteBook(id);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string title = txtBoxSearchTitle.Text.Trim();
            
            if (!string.IsNullOrEmpty(title))
            {
                SearchBookTitleAsync(title);
            }
            else
            {
                MessageBox.Show("Searchfield is Empty!");
            }
        }
    }
}
