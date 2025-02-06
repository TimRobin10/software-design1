namespace sortingApp
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
            listBoxResult = new ListBox();
            btnBubbleSort = new Button();
            btnOOPSort = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 15;
            listBoxResult.Location = new Point(424, 28);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(350, 379);
            listBoxResult.TabIndex = 0;
            // 
            // btnBubbleSort
            // 
            btnBubbleSort.Location = new Point(105, 28);
            btnBubbleSort.Name = "btnBubbleSort";
            btnBubbleSort.Size = new Size(168, 57);
            btnBubbleSort.TabIndex = 1;
            btnBubbleSort.Text = "Bubble Sort";
            btnBubbleSort.UseVisualStyleBackColor = true;
            btnBubbleSort.Click += btnBubbleSort_Click;
            // 
            // btnOOPSort
            // 
            btnOOPSort.Location = new Point(105, 112);
            btnOOPSort.Name = "btnOOPSort";
            btnOOPSort.Size = new Size(168, 57);
            btnOOPSort.TabIndex = 2;
            btnOOPSort.Text = "OOP Sort";
            btnOOPSort.UseVisualStyleBackColor = true;
            btnOOPSort.Click += btnOOPSort_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(105, 196);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(168, 57);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResult);
            Controls.Add(btnReset);
            Controls.Add(btnOOPSort);
            Controls.Add(btnBubbleSort);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxResult;
        private Button btnBubbleSort;
        private Button btnOOPSort;
        private Button btnReset;
    }
}
