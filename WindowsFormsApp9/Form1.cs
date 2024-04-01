using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        private Dictionary<string, decimal> exchangeRates = new Dictionary<string, decimal>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Инициализация списка валют
            List<string> currencies = new List<string> { "USD", "EUR", "GBP", "JPY" };

            comboBoxFromCurrency.DataSource = currencies.ToList(); // Используйте ToList() для создания копии списка
            comboBoxToCurrency.DataSource = currencies.ToList();

            // Установка начальных курсов валют
            exchangeRates.Add("USD", 1.0m);
            exchangeRates.Add("EUR", 0.85m);
            exchangeRates.Add("GBP", 0.73m);
            exchangeRates.Add("JPY", 110.0m);
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                string fromCurrency = comboBoxFromCurrency.SelectedItem.ToString();
                string toCurrency = comboBoxToCurrency.SelectedItem.ToString();
                decimal amount = decimal.Parse(textBoxAmount.Text);

                decimal result = ConvertCurrency(amount, fromCurrency, toCurrency);
                labelResult.Text = $"Результат: {result} {toCurrency}";

                // Логирование операции
                listBoxLog.Items.Add($"{DateTime.Now}: {amount} {fromCurrency} -> {result} {toCurrency}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
        {
            decimal fromRate = exchangeRates[fromCurrency];
            decimal toRate = exchangeRates[toCurrency];

            return amount * (toRate / fromRate);
        }

        private void openSecondFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Открытие второй формы (формы с курсовыми данными)
            var passwordForm = new PasswordForm();
            if (passwordForm.ShowDialog() == DialogResult.OK)
            {
                var exchangeRateForm = new ExchangeRateForm(exchangeRates);
                exchangeRateForm.ShowDialog();
            }
        }
    }
}