namespace RecursiveFibonacci
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
            label1 = new Label();
            label2 = new Label();
            textBoxInput = new TextBox();
            label3 = new Label();
            labelResult = new Label();
            sequenceButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(185, 39);
            label1.Name = "label1";
            label1.Size = new Size(414, 50);
            label1.TabIndex = 0;
            label1.Text = "FIBONACCI SEQUENCE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 125);
            label2.Name = "label2";
            label2.Size = new Size(151, 28);
            label2.TabIndex = 1;
            label2.Text = "Input Number:";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(72, 168);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(199, 27);
            textBoxInput.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 238);
            label3.Name = "label3";
            label3.Size = new Size(202, 28);
            label3.TabIndex = 3;
            label3.Text = "Resulting Sequence:";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelResult.Location = new Point(72, 281);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 28);
            labelResult.TabIndex = 4;
            // 
            // sequenceButton
            // 
            sequenceButton.Location = new Point(404, 133);
            sequenceButton.Name = "sequenceButton";
            sequenceButton.Size = new Size(195, 62);
            sequenceButton.TabIndex = 5;
            sequenceButton.Text = "Make Sequence";
            sequenceButton.UseVisualStyleBackColor = true;
            sequenceButton.Click += sequenceButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sequenceButton);
            Controls.Add(labelResult);
            Controls.Add(label3);
            Controls.Add(textBoxInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxInput;
        private Label label3;
        private Label labelResult;
        private Button sequenceButton;
    }
}
