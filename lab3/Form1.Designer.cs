namespace lab3
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
            showInfoButton = new Button();
            bookListBox = new ListBox();
            SuspendLayout();
            // 
            // showInfoButton
            // 
            showInfoButton.Location = new Point(44, 171);
            showInfoButton.Name = "showInfoButton";
            showInfoButton.Size = new Size(257, 65);
            showInfoButton.TabIndex = 0;
            showInfoButton.Text = "Show Book Info";
            showInfoButton.UseVisualStyleBackColor = true;
            showInfoButton.Click += showInfoButton_Click;
            // 
            // bookListBox
            // 
            bookListBox.FormattingEnabled = true;
            bookListBox.Location = new Point(335, 28);
            bookListBox.Name = "bookListBox";
            bookListBox.Size = new Size(431, 384);
            bookListBox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bookListBox);
            Controls.Add(showInfoButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button showInfoButton;
        private ListBox bookListBox;
    }
}
