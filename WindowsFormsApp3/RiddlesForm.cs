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
    public partial class RiddlesForm : Form
    {
        public RiddlesForm(Dictionary<string, string> riddles)
        {
            InitializeComponent();
            InitializeRiddles(riddles);
        }

        private void InitializeRiddles(Dictionary<string, string> riddles)
        {
            // Заполнение списка загадок и ответов на второй форме
            foreach (KeyValuePair<string, string> riddle in riddles)
            {
                listBox1.Items.Add(riddle.Key);
                listBox2.Items.Add(riddle.Value);
            }
        }

        private void RiddlesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
