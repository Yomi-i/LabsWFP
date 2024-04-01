using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private List<string> names = new List<string>();
        private List<string> surnames = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string surname = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                MessageBox.Show("Пожалуйста, введите имя и фамилию.");
                return;
            }

            if (names.Contains(name))
            {
                MessageBox.Show("Это имя уже добавлено.");
                return;
            }

            if (surnames.Contains(surname))
            {
                MessageBox.Show("Эта фамилия уже добавлена.");
                return;
            }

            names.Add(name);
            surnames.Add(surname);

            listBox1.Items.Add(name);
            listBox2.Items.Add(surname);

            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var showNamesForm = new ShowNamesForm(names, surnames);
            showNamesForm.ShowDialog();
        }
    }
}
