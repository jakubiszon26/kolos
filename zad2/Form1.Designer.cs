namespace zad2
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
            tb1 = new TextBox();
            tb2 = new TextBox();
            btn1 = new Button();
            rtb1 = new RichTextBox();
            SuspendLayout();
            // 
            // tb1
            // 
            tb1.Location = new Point(12, 38);
            tb1.Name = "tb1";
            tb1.Size = new Size(100, 23);
            tb1.TabIndex = 0;
            // 
            // tb2
            // 
            tb2.Location = new Point(12, 76);
            tb2.Name = "tb2";
            tb2.Size = new Size(100, 23);
            tb2.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Location = new Point(21, 105);
            btn1.Name = "btn1";
            btn1.Size = new Size(75, 23);
            btn1.TabIndex = 2;
            btn1.Text = "Przelicz";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // rtb1
            // 
            rtb1.Location = new Point(12, 134);
            rtb1.Name = "rtb1";
            rtb1.Size = new Size(100, 96);
            rtb1.TabIndex = 3;
            rtb1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(130, 275);
            Controls.Add(rtb1);
            Controls.Add(btn1);
            Controls.Add(tb2);
            Controls.Add(tb1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb1;
        private TextBox tb2;
        private Button btn1;
        private RichTextBox rtb1;
    }
}
