namespace Laba_2_2
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
            this.first = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(12, 251);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(144, 63);
            this.Result.TabIndex = 0;
            this.Result.Text = "Вывод результата";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            this.Result.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Result_KeyDown);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(218, 251);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(144, 63);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Очистка полей";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.MaximumSize = new System.Drawing.Size(350, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 80);
            this.label1.TabIndex = 2;
            this.label1.Text = "Даны два слова. Для каждой буквы первого слова определить, входит ли она во второ" +
    "е слово. Повторяющиеся буквы первого слова не рассматривать. ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите первое слово";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Введите второе слово";
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(223, 128);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(139, 27);
            this.first.TabIndex = 5;
            this.first.KeyDown += new System.Windows.Forms.KeyEventHandler(this.first_KeyDown);
            // 
            // second
            // 
            this.second.Location = new System.Drawing.Point(223, 184);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(139, 27);
            this.second.TabIndex = 6;
            this.second.KeyDown += new System.Windows.Forms.KeyEventHandler(this.second_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 348);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
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
        private System.Windows.Forms.TextBox first;
        private System.Windows.Forms.TextBox second;
    }
}

