using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp0
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            int totalLength, latinChars, digits, otherChars;

            if (int.TryParse(lengthTextBox.Text, out totalLength) &&
                int.TryParse(latinTextBox.Text, out latinChars) &&
                int.TryParse(digitsTextBox.Text, out digits))
            {
                otherChars = totalLength - (latinChars + digits);
                if (otherChars < 0)
                {
                    MessageBox.Show("Некорректные значения. Общая длина пароля должна быть не меньше суммы латинских символов и цифр.");
                    return;
                }

                string password = GeneratePassword(latinChars, digits, otherChars);
                listBoxPasswords.Items.Insert(0, password);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
            }
        }

        private string GeneratePassword(int latinChars, int digits, int otherChars)
        {
            const string latinAlphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digitsAlphabet = "0123456789";
            const string otherCharsAlphabet = "@#+-()-+?";

            Random random = new Random();
            StringBuilder passwordBuilder = new StringBuilder();

            AppendRandomChars(passwordBuilder, latinAlphabet, latinChars, random);
            AppendRandomChars(passwordBuilder, digitsAlphabet, digits, random);
            AppendRandomChars(passwordBuilder, otherCharsAlphabet, otherChars, random);

            // Shuffle the characters in the password
            string password = new string(passwordBuilder.ToString().ToCharArray().OrderBy(_ => random.Next()).ToArray());
            return password;
        }

        private void AppendRandomChars(StringBuilder builder, string charSet, int count, Random random)
        {
            for (int i = 0; i < count; i++)
            {
                int index = random.Next(charSet.Length);
                builder.Append(charSet[index]);
            }
        }

        private void showPasswordsButton_Click(object sender, EventArgs e)
        {
            PasswordsForm passwordsForm = new PasswordsForm(listBoxPasswords);
            passwordsForm.ShowDialog();
        }
    }
}
