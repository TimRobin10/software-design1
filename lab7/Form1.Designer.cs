namespace lab7
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
            btnSearch = new Button();
            txtBoxSearchTitle = new TextBox();
            btnDelete = new Button();
            txtBookIDDelete = new TextBox();
            txtBoxUpdateAuthor = new TextBox();
            btnUpdate = new Button();
            txtBoxUpdateTitle = new TextBox();
            txtBoxUpdateID = new TextBox();
            button1 = new Button();
            txtBookTitle = new TextBox();
            txtAuthorName = new TextBox();
            listBookBox = new ListBox();
            btn_FetchBooks = new Button();
            lblPageNumber = new Label();
            btnNextPage = new Button();
            btnPrevPage = new Button();
            btnExportBooks = new Button();
            txtBoxFileName = new TextBox();
            txtBoxImportFilePath = new TextBox();
            btnImportBooks = new Button();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(142, 400);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 33);
            btnSearch.TabIndex = 27;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtBoxSearchTitle
            // 
            txtBoxSearchTitle.Location = new Point(34, 367);
            txtBoxSearchTitle.Name = "txtBoxSearchTitle";
            txtBoxSearchTitle.PlaceholderText = "Book ID";
            txtBoxSearchTitle.Size = new Size(354, 27);
            txtBoxSearchTitle.TabIndex = 26;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(151, 328);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(96, 33);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtBookIDDelete
            // 
            txtBookIDDelete.Location = new Point(34, 295);
            txtBookIDDelete.Name = "txtBookIDDelete";
            txtBookIDDelete.PlaceholderText = "Book ID";
            txtBookIDDelete.Size = new Size(354, 27);
            txtBookIDDelete.TabIndex = 24;
            // 
            // txtBoxUpdateAuthor
            // 
            txtBoxUpdateAuthor.Location = new Point(34, 232);
            txtBoxUpdateAuthor.Name = "txtBoxUpdateAuthor";
            txtBoxUpdateAuthor.PlaceholderText = "New Author";
            txtBoxUpdateAuthor.Size = new Size(354, 27);
            txtBoxUpdateAuthor.TabIndex = 23;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(153, 261);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(96, 28);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtBoxUpdateTitle
            // 
            txtBoxUpdateTitle.Location = new Point(34, 199);
            txtBoxUpdateTitle.Name = "txtBoxUpdateTitle";
            txtBoxUpdateTitle.PlaceholderText = "New Title";
            txtBoxUpdateTitle.Size = new Size(354, 27);
            txtBoxUpdateTitle.TabIndex = 21;
            // 
            // txtBoxUpdateID
            // 
            txtBoxUpdateID.Location = new Point(34, 166);
            txtBoxUpdateID.Name = "txtBoxUpdateID";
            txtBoxUpdateID.PlaceholderText = "Book ID";
            txtBoxUpdateID.Size = new Size(354, 27);
            txtBoxUpdateID.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(153, 125);
            button1.Name = "button1";
            button1.Size = new Size(96, 31);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(34, 92);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.PlaceholderText = "Book Title";
            txtBookTitle.Size = new Size(354, 27);
            txtBookTitle.TabIndex = 18;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(34, 59);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.PlaceholderText = "Book Author";
            txtAuthorName.Size = new Size(354, 27);
            txtAuthorName.TabIndex = 17;
            // 
            // listBookBox
            // 
            listBookBox.FormattingEnabled = true;
            listBookBox.Location = new Point(411, 13);
            listBookBox.Name = "listBookBox";
            listBookBox.Size = new Size(365, 384);
            listBookBox.TabIndex = 16;
            // 
            // btn_FetchBooks
            // 
            btn_FetchBooks.Location = new Point(153, 13);
            btn_FetchBooks.Name = "btn_FetchBooks";
            btn_FetchBooks.Size = new Size(96, 40);
            btn_FetchBooks.TabIndex = 15;
            btn_FetchBooks.Text = "Fetch Books";
            btn_FetchBooks.UseVisualStyleBackColor = true;
            btn_FetchBooks.Click += btn_FetchBooks_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(569, 413);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(50, 20);
            lblPageNumber.TabIndex = 28;
            lblPageNumber.Text = "label1";
            // 
            // btnNextPage
            // 
            btnNextPage.Location = new Point(661, 409);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(38, 29);
            btnNextPage.TabIndex = 29;
            btnNextPage.Text = ">";
            btnNextPage.UseVisualStyleBackColor = true;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnPrevPage
            // 
            btnPrevPage.Location = new Point(489, 409);
            btnPrevPage.Name = "btnPrevPage";
            btnPrevPage.Size = new Size(38, 29);
            btnPrevPage.TabIndex = 30;
            btnPrevPage.Text = "<";
            btnPrevPage.UseVisualStyleBackColor = true;
            btnPrevPage.Click += btnPrevPage_Click;
            // 
            // btnExportBooks
            // 
            btnExportBooks.Location = new Point(25, 453);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(124, 29);
            btnExportBooks.TabIndex = 31;
            btnExportBooks.Tag = "";
            btnExportBooks.Text = "Export Books";
            btnExportBooks.UseVisualStyleBackColor = true;
            btnExportBooks.Click += btnExportBooks_Click;
            // 
            // txtBoxFileName
            // 
            txtBoxFileName.Location = new Point(155, 455);
            txtBoxFileName.Name = "txtBoxFileName";
            txtBoxFileName.PlaceholderText = "File Name (Always append file format)";
            txtBoxFileName.Size = new Size(621, 27);
            txtBoxFileName.TabIndex = 32;
            // 
            // txtBoxImportFilePath
            // 
            txtBoxImportFilePath.Location = new Point(155, 490);
            txtBoxImportFilePath.Name = "txtBoxImportFilePath";
            txtBoxImportFilePath.PlaceholderText = "Enter filepath";
            txtBoxImportFilePath.Size = new Size(621, 27);
            txtBoxImportFilePath.TabIndex = 34;
            // 
            // btnImportBooks
            // 
            btnImportBooks.Location = new Point(25, 488);
            btnImportBooks.Name = "btnImportBooks";
            btnImportBooks.Size = new Size(124, 29);
            btnImportBooks.TabIndex = 33;
            btnImportBooks.Tag = "";
            btnImportBooks.Text = "Import Books";
            btnImportBooks.UseVisualStyleBackColor = true;
            btnImportBooks.Click += btnImportBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 529);
            Controls.Add(txtBoxImportFilePath);
            Controls.Add(btnImportBooks);
            Controls.Add(txtBoxFileName);
            Controls.Add(btnExportBooks);
            Controls.Add(btnPrevPage);
            Controls.Add(btnNextPage);
            Controls.Add(lblPageNumber);
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

        private Button btnSearch;
        private TextBox txtBoxSearchTitle;
        private Button btnDelete;
        private TextBox txtBookIDDelete;
        private TextBox txtBoxUpdateAuthor;
        private Button btnUpdate;
        private TextBox txtBoxUpdateTitle;
        private TextBox txtBoxUpdateID;
        private Button button1;
        private TextBox txtBookTitle;
        private TextBox txtAuthorName;
        private ListBox listBookBox;
        private Button btn_FetchBooks;
        private Label lblPageNumber;
        private Button btnNextPage;
        private Button btnPrevPage;
        private Button btnExportBooks;
        private TextBox txtBoxFileName;
        private TextBox txtBoxImportFilePath;
        private Button btnImportBooks;
    }
}
