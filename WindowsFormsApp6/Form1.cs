using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDateTimePicker();
            InitializeUrgencyComboBox();
        }


        private void InitializeDateTimePicker()
        {
            // Инициализация DateTimePicker
            dateTimePicker.Value = DateTime.Now;
        }

        private void InitializeUrgencyComboBox()
        {
            // Инициализация ComboBox для срочности
            urgencyComboBox.Items.Add("Обычная");
            urgencyComboBox.Items.Add("Срочная");
            urgencyComboBox.Items.Add("Очень срочная");
            urgencyComboBox.SelectedIndex = 0;
        }

      
        private bool IsValidDate(DateTime date)
        {
            // Проверка корректности даты
            try
            {
                DateTime tempDate = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, 0);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void leaveNoteButton_Click(object sender, EventArgs e)
        {
            // Получение данных из полей
            string noteText = noteTextBox.Text;
            DateTime selectedDateTime = dateTimePicker.Value;
            string urgency = urgencyComboBox.SelectedItem.ToString();

            // Проверка введенной даты
            if (!IsValidDate(selectedDateTime))
            {
                MessageBox.Show("Неверная дата.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создание нового окна для отображения заметки
            NoteForm noteForm = new NoteForm(noteText, selectedDateTime, urgency);
            noteForm.Show();

            // Очистка полей формы
            noteTextBox.Clear();
            InitializeDateTimePicker();
            urgencyComboBox.SelectedIndex = 0;
        }
    }
}
