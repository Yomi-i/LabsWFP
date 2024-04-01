using System;
using System.Windows.Forms;

namespace WindowsFormsApp0
{
    public partial class PasswordsForm : Form
    {
        private ListBox listBoxPasswords;

        public PasswordsForm(ListBox listBoxPasswords)
        {
            InitializeComponent();
            this.listBoxPasswords = listBoxPasswords;
        }

        private void PasswordsForm_Load(object sender, EventArgs e)
        {
            foreach (var item in listBoxPasswords.Items)
            {
                listBox.Items.Add(item);
            }
        }
    }
}
