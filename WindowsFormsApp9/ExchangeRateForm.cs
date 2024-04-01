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
    public partial class ExchangeRateForm : Form
    {
        private Dictionary<string, decimal> exchangeRates;

        public ExchangeRateForm(Dictionary<string, decimal> exchangeRates)
        {
            InitializeComponent();
            this.exchangeRates = exchangeRates;
        }

        private void ExchangeRateForm_Load(object sender, EventArgs e)
        {
            foreach (var kvp in exchangeRates)
            {
                listBoxExchangeRates.Items.Add($"{kvp.Key}: {kvp.Value}");
            }
        }

        private void buttonUpdateRates_Click(object sender, EventArgs e)
        {
            UpdateExchangeRate("USD", textBoxEditUSD.Text);
            UpdateExchangeRate("EUR", textBoxEditEUR.Text);
            UpdateExchangeRate("GBP", textBoxEditGBP.Text);
            UpdateExchangeRate("JPY", textBoxEditJPY.Text);

            listBoxExchangeRates.Items.Clear();
            foreach (var kvp in exchangeRates)
            {
                listBoxExchangeRates.Items.Add($"{kvp.Key}: {kvp.Value}");
            }
        }

        private void UpdateExchangeRate(string currency, string rateText)
        {
            if (decimal.TryParse(rateText, out decimal rate))
            {
                if (exchangeRates.ContainsKey(currency))
                {
                    exchangeRates[currency] = rate;
                }
                else
                {
                    exchangeRates.Add(currency, rate);
                }
            }
            //else
            //{
            //    MessageBox.Show($"Ошибка при вводе курса для {currency}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}