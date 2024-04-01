using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        // Добавим массивы для предварительного заполнения ComboBox
        private string[] streets = { "ул. Первая", "ул. Вторая", "ул. Третья" };
        private string[] arrivalPlaces = { "Ж.Д. вокзал", "Аэропорт", "Другое" };
        public Form1()
        {
            InitializeComponent();

            // Заполняем ComboBox данными
            streetComboBox.Items.AddRange(streets);
            arrivalPlaceComboBox.Items.AddRange(arrivalPlaces);
        }

        private void ClearInputFields()
        {
            streetComboBox.SelectedIndex = -1; // Сбрасываем выбор в ComboBox
            houseTextBox.Text = "";
            entranceTextBox.Text = "";
            timeTextBox.Text = "";
            arrivalPlaceComboBox.SelectedIndex = -1; // Сбрасываем выбор в ComboBox
            commentsTextBox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Получение данных от диспетчера
            string street = streetComboBox.SelectedItem?.ToString() ?? ""; // Используем выбранный элемент из ComboBox
            string house = houseTextBox.Text;
            string entrance = entranceTextBox.Text;
            string time = timeTextBox.Text;
            string arrivalPlace = arrivalPlaceComboBox.SelectedItem?.ToString() ?? ""; // Используем выбранный элемент из ComboBox
            string comments = commentsTextBox.Text;

            string requestInfo;

            if (arrivalPlaceComboBox.SelectedItem != null)
            {
                requestInfo = $"Время: {time} - Место прибытия: {arrivalPlace}";
            }
            else
            {
                // Формирование строки для отображения в листбоксе
                requestInfo = $"Время: {time} - Улица: {street}, Дом: {house}, Подъезд: {entrance}, Комментарий: {comments}";
            }
            

            // Добавление заявки в листбокс
            requestsListBox.Items.Add(requestInfo);

            // Очистка полей ввода после добавления заявки
            ClearInputFields();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
