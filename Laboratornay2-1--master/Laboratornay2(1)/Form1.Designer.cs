namespace Laboratornay2_1_
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
            this.Result = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 364);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(151, 54);
            this.Result.TabIndex = 0;
            this.Result.Text = "Результат";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            this.Result.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Result_KeyDown);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(206, 361);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(151, 57);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Очистить все поля";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.MaximumSize = new System.Drawing.Size(350, 1200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "Даны вещественные положительные числа a, b, c. Если существует треугольник со сто" +
    "ронами a, b, c, то определить, является ли он прямоугольным.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите первую сторону";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите вторую сторону";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Введите третью сторону";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(217, 144);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(140, 27);
            this.a.TabIndex = 6;
            this.a.KeyDown += new System.Windows.Forms.KeyEventHandler(this.a_KeyDown);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(217, 211);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(140, 27);
            this.b.TabIndex = 7;
            this.b.KeyDown += new System.Windows.Forms.KeyEventHandler(this.b_KeyDown);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(217, 280);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(140, 27);
            this.c.TabIndex = 8;
            this.c.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 448);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Result);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox c;
    }
}

