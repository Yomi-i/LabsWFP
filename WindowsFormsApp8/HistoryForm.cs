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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        public void AddWashHistory(string washMode, int temperature)
        {
            listBoxHistory.Items.Add($"Режим: {washMode}, Температура: {temperature}°C");
        }
    }
}
