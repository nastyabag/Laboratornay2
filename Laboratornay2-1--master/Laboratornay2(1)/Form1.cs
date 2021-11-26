using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratornay2_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            a.Text = Properties.Settings.Default.a.ToString();//считываем значения из настроек для последующего сохранения
            b.Text = Properties.Settings.Default.b.ToString();
            c.Text = Properties.Settings.Default.c.ToString();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            int a, b, c;
            try //проверка ввода данных
            {
                a = int.Parse(this.a.Text);
                b = int.Parse(this.b.Text);
                c = int.Parse(this.c.Text);
            }
            catch (FormatException)
            {
                // сообщение об ошибке
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Properties.Settings.Default.a = a;
            Properties.Settings.Default.b = b;
            Properties.Settings.Default.c = c;
            Properties.Settings.Default.Save(); //сохраняем переданные значения, для восстановления при следующем запуске

            MessageBox.Show(Logic.GetResult(a, b, c), "Результат");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            a.Text = "";
            a.Clear();
            b.Text = "";
            b.Clear();
            c.Text = "";
            c.Clear();
        }
        //Переход к элементам формы с помощью enter
        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void a_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                b.Focus();
            }
        }
        private void b_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                c.Focus();
            }
        }
        private void c_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Result.Focus();
            }
        }

        private void Result_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                a.Focus();
            }
        }
    }

    public class Logic // класс где будем хранить логику
    {
        public static string GetResult(int a, int b, int c)
        {
            string result = "";
            if ((a < b + c) & (b < a + c) & (c < a + b))//проверка существует ли треугольник
            {
                if ((Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2)) || (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2)) || (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)))
                    //проверка являлется ли треугольник прямоугольным                                                                                                    
                    result = "Треугольник прямоугольный";
                else
                    result = "Треугольник не прямоугольный";
            }
            else
                result = "Треугольник не существует";
            return result;
        }
    }
}
