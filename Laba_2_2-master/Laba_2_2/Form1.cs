using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            first.Text = Properties.Settings.Default.first.ToString();//считываем значения из настроек для последующего сохранения
            second.Text = Properties.Settings.Default.second.ToString();
        }

        private void Result_Click(object sender, EventArgs e)
        {
            string first;
            string second;
            first = this.first.Text;
            second = this.second.Text;
            //проверка ввода
            Regex r = new Regex("^[a-zA-Z*$]");
            if (r.IsMatch(first))
            {
                if (r.IsMatch(second))
                {
                    MessageBox.Show(Logic.GetResult(first, second), "Результат");
                }
            }    
            else
            {
                MessageBox.Show("Некорректный ввод", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Properties.Settings.Default.first = first;
            Properties.Settings.Default.second = second;
            Properties.Settings.Default.Save(); //сохраняем переданные значения, для восстановления при следующем запуске
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            first.Text = "";
            first.Clear();
            second.Text = "";
            second.Clear();
        }

        //Переход к элементам формы с помощью enter
        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void first_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                second.Focus();
            }
        }
        private void second_KeyDown(object sender, KeyEventArgs e)
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
                first.Focus();
            }
        }

    }

    public class Logic //класс для выполнения логических действий
    {
        public static string GetResult(string first, string second) //функция для выполнения действий
        {
            string result = string.Empty;

            //удаляем повторяющиеся символы
            for (int i = 0; i <= first.Length - 2; i++)
            {
                for (int j = i + 1; j <= first.Length - 1; j++)
                {
                    if (first[i] == first[j])
                        first = first.Remove(j, 1);
                }
            }

            //проверяем содержит ли вторая строка символы первой
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != ' ') //исправление ошибки
                {
                    if (second.Contains(first[i]))
                        result += "да ";
                    else
                        result += "нет ";
                }
            }

            return result;
        }
    }
}
