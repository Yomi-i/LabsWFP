using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private string secretWord;
        private List<char> guessedLetters = new List<char>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Загадываем слово (можно заменить на более сложный механизм загадывания)
            secretWord = "chipi";

            // Отображаем описание слова
            label1.Text = "Котик чувствует";

            // Очищаем поле для ввода
            textBox1.Text = new string('*', secretWord.Length);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Проверяем, введена ли буква
            if (textBox1.Text.Length != 1)
            {
                MessageBox.Show("Введите только одну букву!");
                return;
            }

            char guessedLetter = textBox1.Text[0];

            // Проверяем, встречается ли буква в загаданном слове
            bool found = false;
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == guessedLetter)
                {
                    guessedLetters.Add(guessedLetter);
                    textBox1.Text = UpdateDisplayWord();
                    found = true;
                }
            }

            // Если буква не найдена, добавляем в историю ходов
            if (!found)
            {
                MessageBox.Show($"Буквы '{guessedLetter}' нет в слове");
                listBox1.Items.Add($"Буквы '{guessedLetter}' нет в слове");
            }
            else
            {
                // Если слово угадано полностью, показываем сообщение об этом
                if (textBox1.Text == secretWord)
                {
                    MessageBox.Show("Поздравляем! Вы угадали слово!");
                }
            }
        }

        private string UpdateDisplayWord()
        {
            // Обновляем отображаемое слово с учетом угаданных букв
            string displayWord = "";
            foreach (char letter in secretWord)
            {
                if (guessedLetters.Contains(letter))
                {
                    displayWord += letter;
                }
                else
                {
                    displayWord += "*";
                }
            }
            return displayWord;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 historyForm = new Form2(listBox1.Items);
            historyForm.Show();
        }
    }
}
