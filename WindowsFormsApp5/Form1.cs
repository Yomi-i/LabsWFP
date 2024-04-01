using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> productList = new Dictionary<string, int>
        {
            {"Яблоки", 254},
            {"Груши", 123},
            // Добавьте другие товары и их коды по необходимости
        };

        private Dictionary<string, int> countryList = new Dictionary<string, int>
        {
            {"Испания", 5},
            {"Германия", 10},
            // Добавьте другие страны и их коды по необходимости
        };

        public Form1()
        {
            InitializeComponent();
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            foreach (var product in productList.Keys)
            {
                productNameComboBox.Items.Add(product);
            }

            foreach (var country in countryList.Keys)
            {
                countryComboBox.Items.Add(country);
            }
        }


        private void showCodesButton_Click(object sender, EventArgs e)
        {
            CodesForm codesForm = new CodesForm(listBox.Items);
            codesForm.ShowDialog();
        }

        private void generateCodeButton_Click(object sender, EventArgs e)
        {
            if (productNameComboBox.SelectedItem == null || countryComboBox.SelectedItem == null || string.IsNullOrEmpty(weightTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }

            string productName = productNameComboBox.SelectedItem.ToString();
            int productCode = productList[productName];
            int weightCode = int.Parse(weightTextBox.Text);
            string countryName = countryComboBox.SelectedItem.ToString();
            int countrycode = countryList[countryName];

            string generatedCode = ($"{countrycode} {productCode} {weightCode}");

            listBox.Items.Add($"Товар: {productName} (Код {productCode}), Вес: {weightCode} гр., Страна: {countryName} (Код {countrycode}) - Сгенерированный код: {generatedCode}");
        }
    }
}
