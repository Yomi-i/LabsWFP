using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class PasswordForm : Form
    {
        private const string correctPassword = "pass";

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredPassword = textBox1.Text.Trim();

            if (enteredPassword == correctPassword)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Неверный пароль. Пожалуйста, попробуйте снова.");
                textBox1.Clear();
            }
        }
    }
}
