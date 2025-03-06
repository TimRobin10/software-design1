using lab5;
using Microsoft.EntityFrameworkCore;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public const int pageSize = 10;
        private int currentPage = 1;

        public async Task<List<String>> GetBooksByPageAsync(int pageNumber)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                    .Include(b => b.Author)
                    .OrderBy(b => b.BookID)
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .Select(b => $"Book ID: {b.BookID} | {b.Title} by {b.Author.Name}")
                    .ToListAsync();

                return books;
            }
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
            try
            {
                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authroName };
                    var book = new Book { Title = bookTitle, Author = author };

                    var authorValidation = await context.Authors
                        .FirstOrDefaultAsync(a=> a.Name == authroName);
                    if(authorValidation == null)
                    {
                        context.Authors.Add(author);
                    }

                    var bookvalidation = await context.Books
                        .FirstOrDefaultAsync(b=> b.Title == bookTitle && b.Author == author);
                    if(bookvalidation == null)
                    {
                        context.Books.Add(book);
                    }
                    else
                    {
                        MessageBox.Show("Book Already Exist");
                    }

                    await context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured :" + ex.Message);
            }
        }

        public async Task SearchBookTitleAsync(string bookTitle)
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show("An error occured: " + e.Message);
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

        public async Task ExportBooksAsync(string filename)
        {
            var books = await GetBooksByPageAsync(currentPage);
            string filepath = Path.Combine("C:/Users/Timro/Downloads/Exports/", filename);

            try
            {
                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    foreach (var book in books)
                    {
                        await writer.WriteLineAsync(book);
                    }
                }
                MessageBox.Show("Booklist exported successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message);
            }
        }

        public async Task ImportBooksAsync(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File not found!");
                    return;
                }

                var lines = await File.ReadAllLinesAsync(filePath);

                using (var context = new BookstoreContext())
                {
                    foreach (var line in lines)
                    {
                        var parts = line.Split(',');
                        if (parts.Length < 2) continue;

                        string title = parts[0].Trim();
                        string authorName = parts[1].Trim();

                        var author = await context.Authors.FirstOrDefaultAsync(a => a.Name == authorName);
                        if (author == null)
                        {
                            author = new Author { Name = authorName };
                            context.Authors.Add(author);
                        }

                        var validateBookCopies = await context.Books
                            .FirstOrDefaultAsync(b=>b.Title == title);
                        if (validateBookCopies == null){
                            var book = new Book { Title = title, Author = author };
                            context.Books.Add(book);
                        }
                        
                    }

                    await context.SaveChangesAsync();
                }

                MessageBox.Show("Books imported successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            var books = await GetBooksAsync();
            int pageCeil = (int)Math.Ceiling((double)books.Count() / pageSize);

            if (currentPage < pageCeil)
            {
                currentPage++;
                var booksPage = await GetBooksByPageAsync(currentPage);
                listBookBox.DataSource = booksPage;
                lblPageNumber.Text = $"Page {currentPage}";
            }

        }

        private async void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
            }

            var books = await GetBooksByPageAsync(currentPage);
            listBookBox.DataSource = books;
            lblPageNumber.Text = $"Page {currentPage}";
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

        private async void btn_FetchBooks_Click(object sender, EventArgs e)
        {
            var books = await GetBooksByPageAsync(currentPage);
            listBookBox.DataSource = books;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookAsync(bookTitle, authorName);

            MessageBox.Show("Book and Author added Successfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblPageNumber.Text = "Page 1";
        }

        private async void btnExportBooks_Click(object sender, EventArgs e)
        {
            string filename = txtBoxFileName.Text;
            if (!string.IsNullOrEmpty(filename))
            {
                await ExportBooksAsync(filename);
            }
            else
            {
                MessageBox.Show("Invalid Filename");
            }
        }

        private async void btnImportBooks_Click(object sender, EventArgs e)
        {
            string filePath = txtBoxImportFilePath.Text;

            if (!string.IsNullOrEmpty(filePath))
            {
                await ImportBooksAsync(filePath);
            }
            else
            {
                MessageBox.Show("Invalid FilePath");
            }
        }
    }
}
