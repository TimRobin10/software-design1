namespace lab5
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
            listBookBox = new ListBox();
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            button1 = new Button();
            txtBoxID = new TextBox();
            txtAuthorNameUpdate = new TextBox();
            txtBookTitleUpdate = new TextBox();
            btnUpdate = new Button();
            txtBookIDDel = new TextBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // listBookBox
            // 
            listBookBox.FormattingEnabled = true;
            listBookBox.Location = new Point(457, 12);
            listBookBox.Name = "listBookBox";
            listBookBox.Size = new Size(331, 424);
            listBookBox.TabIndex = 0;
            listBookBox.SelectedIndexChanged += listBookBox_SelectedIndexChanged;
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(28, 28);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.PlaceholderText = "Book Author";
            txtAuthorName.Size = new Size(403, 27);
            txtAuthorName.TabIndex = 1;
            txtAuthorName.TextChanged += txtAuthorName_TextChanged;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(28, 61);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.PlaceholderText = "Book Title";
            txtBookTitle.Size = new Size(403, 27);
            txtBookTitle.TabIndex = 2;
            txtBookTitle.TextChanged += txtBookTitle_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(147, 94);
            button1.Name = "button1";
            button1.Size = new Size(145, 47);
            button1.TabIndex = 3;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBoxID
            // 
            txtBoxID.Location = new Point(28, 147);
            txtBoxID.Name = "txtBoxID";
            txtBoxID.PlaceholderText = "Book ID";
            txtBoxID.Size = new Size(403, 27);
            txtBoxID.TabIndex = 4;
            // 
            // txtAuthorNameUpdate
            // 
            txtAuthorNameUpdate.Location = new Point(28, 180);
            txtAuthorNameUpdate.Name = "txtAuthorNameUpdate";
            txtAuthorNameUpdate.PlaceholderText = "New Book Author";
            txtAuthorNameUpdate.Size = new Size(403, 27);
            txtAuthorNameUpdate.TabIndex = 5;
            // 
            // txtBookTitleUpdate
            // 
            txtBookTitleUpdate.Location = new Point(28, 213);
            txtBookTitleUpdate.Name = "txtBookTitleUpdate";
            txtBookTitleUpdate.PlaceholderText = "new Book Title";
            txtBookTitleUpdate.Size = new Size(403, 27);
            txtBookTitleUpdate.TabIndex = 6;
            txtBookTitleUpdate.TextChanged += txtBookTitleUpdate_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(147, 246);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(145, 47);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtBookIDDel
            // 
            txtBookIDDel.Location = new Point(28, 314);
            txtBookIDDel.Name = "txtBookIDDel";
            txtBookIDDel.PlaceholderText = "Book ID";
            txtBookIDDel.Size = new Size(403, 27);
            txtBookIDDel.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(147, 360);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 47);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(txtBookIDDel);
            Controls.Add(btnUpdate);
            Controls.Add(txtBookTitleUpdate);
            Controls.Add(txtAuthorNameUpdate);
            Controls.Add(txtBoxID);
            Controls.Add(button1);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(listBookBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBookBox;
        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Button button1;
        private TextBox txtBoxID;
        private TextBox txtAuthorNameUpdate;
        private TextBox txtBookTitleUpdate;
        private Button btnUpdate;
        private TextBox txtBookIDDel;
        private Button btnDelete;
    }
}
