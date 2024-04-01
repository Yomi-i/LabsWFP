using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ShowNamesForm : Form
    {
        public ShowNamesForm(List<string> names, List<string> surnames)
        {
            InitializeComponent();

            foreach (var name in names)
            {
                listBox1.Items.Add(name);
            }

            foreach (var surname in surnames)
            {
                listBox2.Items.Add(surname);
            }
        }
    }
}
