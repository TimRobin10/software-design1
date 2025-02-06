namespace RecursivePower
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
            textBoxBase = new TextBox();
            textBoxPower = new TextBox();
            label2 = new Label();
            labelResult = new Label();
            buttonSolve = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 33);
            label1.Name = "label1";
            label1.Size = new Size(360, 50);
            label1.TabIndex = 0;
            label1.Text = "RECURSIVE POWER";
            // 
            // textBoxBase
            // 
            textBoxBase.Location = new Point(70, 136);
            textBoxBase.Name = "textBoxBase";
            textBoxBase.PlaceholderText = "Input Base";
            textBoxBase.Size = new Size(314, 27);
            textBoxBase.TabIndex = 1;
            // 
            // textBoxPower
            // 
            textBoxPower.Location = new Point(404, 136);
            textBoxPower.Name = "textBoxPower";
            textBoxPower.PlaceholderText = "Input Power";
            textBoxPower.Size = new Size(313, 27);
            textBoxPower.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 272);
            label2.Name = "label2";
            label2.Size = new Size(153, 50);
            label2.TabIndex = 3;
            label2.Text = "RESULT";
            // 
            // labelResult
            // 
            labelResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelResult.AutoSize = true;
            labelResult.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelResult.Location = new Point(70, 336);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 38);
            labelResult.TabIndex = 4;
            labelResult.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonSolve
            // 
            buttonSolve.Location = new Point(347, 199);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new Size(94, 48);
            buttonSolve.TabIndex = 5;
            buttonSolve.Text = "Solve";
            buttonSolve.UseVisualStyleBackColor = true;
            buttonSolve.Click += buttonSolve_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSolve);
            Controls.Add(labelResult);
            Controls.Add(label2);
            Controls.Add(textBoxPower);
            Controls.Add(textBoxBase);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxBase;
        private TextBox textBoxPower;
        private Label label2;
        private Label labelResult;
        private Button buttonSolve;
    }
}
