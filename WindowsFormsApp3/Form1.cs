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
    public partial class Form1 : Form
    {
        private int attempts = 0;
        private readonly Dictionary<string, string> riddles = new Dictionary<string, string>();
        private readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeRiddles();
            DisplayRandomRiddle();
        }

        private void InitializeRiddles()
        {
            // Заполнение базы загадок и ответов
            riddles.Add("Что можно увидеть с закрытыми глазами?", "Сон");
            riddles.Add("Что всегда возвращается в момент своего ухода?", "Молодость");
        }

        private void DisplayRandomRiddle()
        {
            // Отображение случайной загадки из словаря
            int index = random.Next(riddles.Count);
            string riddle = riddles.Keys.ToArray()[index];
            label1.Text = riddle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка ответа пользователя
            string userAnswer = textBox1.Text.Trim().ToLower();
            string correctAnswer = riddles[label1.Text].ToLower();


            if (userAnswer == correctAnswer)
            {
                MessageBox.Show("Правильный ответ!");
                DisplayRandomRiddle();
                attempts = 0;
            }
            else
            {
                MessageBox.Show("Неверный ответ!");
                attempts++;

                if (attempts >= 3)
                {
                    MessageBox.Show($"Подсказка: Правильный ответ - {correctAnswer}");
                    attempts = 0;
                }
            }
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var passwordForm = new PasswordForm();
            if (passwordForm.ShowDialog() == DialogResult.OK)
            {
                var riddlesForm = new RiddlesForm(riddles);
                riddlesForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Доступ запрещен.");
            }
        }
    }
}
