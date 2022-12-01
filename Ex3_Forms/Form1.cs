using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            double A = 0, B = 0;

            string[] strs = NumbersTextBox.Text.Split(' ');
            List<uint> result = new List<uint>();

            try
            {
                A = double.Parse(StartTextBox.Text);
                B = double.Parse(EndTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введено некорректное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (string str in strs)
            {
                try
                {
                    double number = double.Parse(str);
                    if ((int)number == number && number > 0 && number >= A && number <= B) result.Add((uint)number);
                }
                catch
                {
                    continue;
                }
            }

            string result_str = string.Empty;

            for (int i = 0; i < result.Count; i++) result_str += result[i] + " ";

            int iterator = 0;
            while (iterator < result.Count)
            {
                result_str += result[iterator] + " ";
                iterator++;
            }

            result_str = string.Empty;
            iterator = 0;
            do
            {
                result_str += result[iterator] + " ";
                iterator++;
            } while (iterator < result.Count);

            MessageBox.Show($"Только положительные целые числа из диапазона от {A} до {B}: {result_str}");
            
        }
    }
}
