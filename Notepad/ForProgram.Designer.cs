namespace Notepad
{
    partial class ForProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(270, 7);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 1;
            label1.Text = "Мій блокнот";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(-4, 46);
            label2.Name = "label2";
            label2.Size = new Size(646, 147);
            label2.TabIndex = 3;
            label2.Text = "\r\nАвтором цього блокноту є  Вєщиков Олег Миколайович, студент спеціальності ІПЗ.\r\nЦей блокнот розроблено для виконання 6 лабораторної з КПЗ.\r\n\r\n\r\n\r\n\r\n";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(74, 193);
            label3.Name = "label3";
            label3.Size = new Size(509, 32);
            label3.TabIndex = 4;
            label3.Text = "Надіюсь вам сподобався мій блокнот!!!";
            // 
            // ForProgram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ForProgram";
            Text = "ForProgram";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }
}