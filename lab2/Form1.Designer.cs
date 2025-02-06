namespace lab2
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
            labelMain = new Label();
            label1 = new Label();
            label2 = new Label();
            labelResult = new Label();
            inputTextBox = new TextBox();
            solveButton = new Button();
            label3 = new Label();
            textBoxArray = new TextBox();
            labelSum = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelMain
            // 
            labelMain.AutoEllipsis = true;
            labelMain.AutoSize = true;
            labelMain.BackColor = SystemColors.Control;
            labelMain.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMain.Location = new Point(189, 36);
            labelMain.Name = "labelMain";
            labelMain.Size = new Size(422, 46);
            labelMain.TabIndex = 0;
            labelMain.Text = "FACTORIAL CALCULATOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 94);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 1;
            label1.Text = "Input Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(461, 94);
            label2.Name = "label2";
            label2.Size = new Size(190, 28);
            label2.TabIndex = 2;
            label2.Text = "Resulting Number:";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResult.Location = new Point(461, 143);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 28);
            labelResult.TabIndex = 3;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(68, 131);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(210, 27);
            inputTextBox.TabIndex = 4;
            // 
            // solveButton
            // 
            solveButton.Location = new Point(318, 174);
            solveButton.Name = "solveButton";
            solveButton.Size = new Size(143, 46);
            solveButton.TabIndex = 5;
            solveButton.Text = "Solve";
            solveButton.UseVisualStyleBackColor = true;
            solveButton.Click += solveButton_Click;
            // 
            // label3
            // 
            label3.AutoEllipsis = true;
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(224, 234);
            label3.Name = "label3";
            label3.Size = new Size(353, 46);
            label3.TabIndex = 6;
            label3.Text = "ARRAY CALCULATOR";
            label3.Click += label3_Click;
            // 
            // textBoxArray
            // 
            textBoxArray.Location = new Point(103, 345);
            textBoxArray.Name = "textBoxArray";
            textBoxArray.Size = new Size(243, 27);
            textBoxArray.TabIndex = 10;
            // 
            // labelSum
            // 
            labelSum.AutoSize = true;
            labelSum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSum.Location = new Point(496, 357);
            labelSum.Name = "labelSum";
            labelSum.Size = new Size(0, 28);
            labelSum.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(496, 308);
            label5.Name = "label5";
            label5.Size = new Size(142, 28);
            label5.TabIndex = 8;
            label5.Text = "Sum of Array:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(103, 308);
            label6.Name = "label6";
            label6.Size = new Size(243, 28);
            label6.TabIndex = 7;
            label6.Text = "Input Array of Numbers:";
            // 
            // button1
            // 
            button1.Location = new Point(318, 392);
            button1.Name = "button1";
            button1.Size = new Size(143, 46);
            button1.TabIndex = 11;
            button1.Text = "Solve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBoxArray);
            Controls.Add(labelSum);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(solveButton);
            Controls.Add(inputTextBox);
            Controls.Add(labelResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelMain);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMain;
        private Label label1;
        private Label label2;
        private Label labelResult;
        private TextBox inputTextBox;
        private Button solveButton;
        private Label label3;
        private TextBox textBoxArray;
        private Label labelSum;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}
