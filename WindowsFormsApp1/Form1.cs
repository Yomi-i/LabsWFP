using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string series = textBox1.Text.Trim();
            string number = textBox2.Text.Trim();

            bool isValid = ValidatePassportData(series, number);
            string result = $"{series} {number} {(isValid ? " - Верно" : " - Неверно")}";


            if (isValid)
            {
                listBox1.Items.Add(result);
            }
            else
            {
                listBox1.Items.Add(result);
            }
        }

        private bool ValidatePassportData(string series, string number)
        {
            // Проверка серии паспорта
            bool validSeries = series.Length == 4 && series.StartsWith("690") && int.TryParse(series.Substring(3), out int seriesNumber) && seriesNumber >= 1 && seriesNumber <= 4;

            // Проверка номера паспорта
            bool validNumber = int.TryParse(number, out int passportNumber) && passportNumber >= 100000 && passportNumber <= 800000;

            return validSeries && validNumber;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 resultsForm = new Form2(listBox1.Items);
            resultsForm.Show();
        }
    }
}
