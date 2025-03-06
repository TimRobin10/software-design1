namespace lab6
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_FetchBooks = new Button();
            listBookBox = new ListBox();
            button1 = new Button();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            btnUpdate = new Button();
            txtBoxUpdateTitle = new TextBox();
            txtBoxUpdateID = new TextBox();
            txtBoxUpdateAuthor = new TextBox();
            btnDelete = new Button();
            txtBookIDDelete = new TextBox();
            btnSearch = new Button();
            txtBoxSearchTitle = new TextBox();
            SuspendLayout();
            // 
            // btn_FetchBooks
            // 
            btn_FetchBooks.Location = new Point(152, 22);
            btn_FetchBooks.Name = "btn_FetchBooks";
            btn_FetchBooks.Size = new Size(96, 40);
            btn_FetchBooks.TabIndex = 0;
            btn_FetchBooks.Text = "Fetch Books";
            btn_FetchBooks.UseVisualStyleBackColor = true;
            btn_FetchBooks.Click += button1_Click;
            // 
            // listBookBox
            // 
            listBookBox.FormattingEnabled = true;
            listBookBox.Location = new Point(410, 22);
            listBookBox.Name = "listBookBox";
            listBookBox.Size = new Size(365, 424);
            listBookBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(152, 134);
            button1.Name = "button1";
            button1.Size = new Size(96, 31);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(33, 101);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.PlaceholderText = "Book Title";
            txtBookTitle.Size = new Size(354, 27);
            txtBookTitle.TabIndex = 5;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(33, 68);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.PlaceholderText = "Book Author";
            txtAuthorName.Size = new Size(354, 27);
            txtAuthorName.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(152, 270);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 28);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtBoxUpdateTitle
            // 
            txtBoxUpdateTitle.Location = new Point(33, 208);
            txtBoxUpdateTitle.Name = "txtBoxUpdateTitle";
            txtBoxUpdateTitle.PlaceholderText = "New Title";
            txtBoxUpdateTitle.Size = new Size(354, 27);
            txtBoxUpdateTitle.TabIndex = 8;
            // 
            // txtBoxUpdateID
            // 
            txtBoxUpdateID.Location = new Point(33, 175);
            txtBoxUpdateID.Name = "txtBoxUpdateID";
            txtBoxUpdateID.PlaceholderText = "Book ID";
            txtBoxUpdateID.Size = new Size(354, 27);
            txtBoxUpdateID.TabIndex = 7;
            // 
            // txtBoxUpdateAuthor
            // 
            txtBoxUpdateAuthor.Location = new Point(33, 241);
            txtBoxUpdateAuthor.Name = "txtBoxUpdateAuthor";
            txtBoxUpdateAuthor.PlaceholderText = "New Author";
            txtBoxUpdateAuthor.Size = new Size(354, 27);
            txtBoxUpdateAuthor.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(150, 337);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 33);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtBookIDDelete
            // 
            txtBookIDDelete.Location = new Point(33, 304);
            txtBookIDDelete.Name = "txtBookIDDelete";
            txtBookIDDelete.PlaceholderText = "Book ID";
            txtBookIDDelete.Size = new Size(354, 27);
            txtBookIDDelete.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(141, 409);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 33);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBoxSearchTitle
            // 
            txtBoxSearchTitle.Location = new Point(24, 376);
            txtBoxSearchTitle.Name = "txtBoxSearchTitle";
            txtBoxSearchTitle.PlaceholderText = "Book ID";
            txtBoxSearchTitle.Size = new Size(354, 27);
            txtBoxSearchTitle.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 458);
            Controls.Add(btnSearch);
            Controls.Add(txtBoxSearchTitle);
            Controls.Add(btnDelete);
            Controls.Add(txtBookIDDelete);
            Controls.Add(txtBoxUpdateAuthor);
            Controls.Add(btnUpdate);
            Controls.Add(txtBoxUpdateTitle);
            Controls.Add(txtBoxUpdateID);
            Controls.Add(button1);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(listBookBox);
            Controls.Add(btn_FetchBooks);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_FetchBooks;
        private ListBox listBookBox;
        private Button button1;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private Button btnUpdate;
        private TextBox txtBoxUpdateTitle;
        private TextBox txtBoxUpdateID;
        private TextBox txtBoxUpdateAuthor;
        private Button btnDelete;
        private TextBox txtBookIDDelete;
        private Button btnSearch;
        private TextBox txtBoxSearchTitle;
    }
}
