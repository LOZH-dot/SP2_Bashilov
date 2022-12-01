using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>() { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

            DaysComboBox.DataSource = list;

            switch (DaysComboBox.Text)
            {
                case "Понедельник":
                    ResultLabel.Text = "с 8:00 до 12:00";
                    break;
                case "Вторник":
                    ResultLabel.Text = "с 8:30 до 12:30";
                    break;
                case "Среда":
                    ResultLabel.Text = "с 8:00 до 15:00";
                    break;
                case "Четверг":
                    ResultLabel.Text = "с 8:00 до 16:00";
                    break;
                case "Пятница":
                    ResultLabel.Text = "с 10:00 до 12:00";
                    break;
                case "Суббота":
                    ResultLabel.Text = "с 9:00 до 11:00";
                    break;
                case "Воскресенье":
                    ResultLabel.Text = "с 8:00 до 17:30";
                    break;
            }

        }

        private void DaysComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DaysComboBox.Text)
            {
                case "Понедельник":
                    ResultLabel.Text = "с 8:00 до 12:00";
                    break;
                case "Вторник":
                    ResultLabel.Text = "с 8:30 до 12:30";
                    break;
                case "Среда":
                    ResultLabel.Text = "с 8:00 до 15:00";
                    break;
                case "Четверг":
                    ResultLabel.Text = "с 8:00 до 16:00";
                    break;
                case "Пятница":
                    ResultLabel.Text = "с 10:00 до 12:00";
                    break;
                case "Суббота":
                    ResultLabel.Text = "с 9:00 до 11:00";
                    break;
                case "Воскресенье":
                    ResultLabel.Text = "с 8:00 до 17:30";
                    break;
            }
        }
    }
}
