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
    public partial class NoteForm : Form
    {
        public NoteForm(string noteText, DateTime dateTime, string urgency)
        {
            InitializeComponent();

            // Отображение данных в новом окне
            noteLabel.Text = $"Заметка: {noteText}";
            dateLabel.Text = $"Дата и время: {dateTime.ToString()}";
            urgencyLabel.Text = $"Срочность: {urgency}";

            // Установка цвета в зависимости от срочности
            SetUrgencyColor(urgency);
        }

        private void SetUrgencyColor(string urgency)
        {
            // Установка цвета в зависимости от срочности
            switch (urgency)
            {
                case "Обычная":
                    urgencyLabel.ForeColor = Color.Green;
                    break;
                case "Срочная":
                    urgencyLabel.ForeColor = Color.Orange;
                    break;
                case "Очень срочная":
                    urgencyLabel.ForeColor = Color.Red;
                    break;
                default:
                    break;
            }
        }
    }
}
