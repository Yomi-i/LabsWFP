using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private HistoryForm historyForm;
        private bool machineLoaded = false;
        private bool washingStarted = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            machineLoaded = !machineLoaded;
            UpdateLoadButton();
        }

        private void UpdateLoadButton()
        {
            if (machineLoaded)
            {
                btnLoad.BackColor = System.Drawing.Color.Red;
                lblStatus.Text = "Станок загружен";
            }
            else
            {
                btnLoad.BackColor = SystemColors.Control;
                lblStatus.Text = "Станок не загружен";
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            // Если форма еще не создана, создайте новый экземпляр
            if (historyForm == null || historyForm.IsDisposed)
            {
                historyForm = new HistoryForm();
            }

            // Отобразите форму
            historyForm.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (machineLoaded)
            {
                washingStarted = true;
                UpdateControlsAvailability();
                Task.Delay(7000).ContinueWith(_ => WashCompleted());

                // Добавьте историю в ListBox на форме HistoryForm
                if (historyForm != null && !historyForm.IsDisposed)
                {
                    historyForm.AddWashHistory(cmbWashMode.SelectedItem.ToString(), trackTemperature.Value);
                }
            }
            else
            {
                MessageBox.Show("Загрузите стиральную машину перед началом стирки.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateControlsAvailability()
        {
            btnLoad.Enabled = !washingStarted;
            cmbWashMode.Enabled = !washingStarted;
            trackTemperature.Enabled = !washingStarted;
            btnStart.Enabled = !washingStarted;
            btnReset.Enabled = washingStarted;
        }

        private void WashCompleted()
        {
            if (washingStarted)
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Стирка завершена.", "Информация", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    washingStarted = false;
                    UpdateControlsAvailability();
                }));
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            washingStarted = false;
            UpdateControlsAvailability();
        }

        
    }
}