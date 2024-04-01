using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class CodesForm : Form
    {
        public CodesForm(ListBox.ObjectCollection codes)
        {
            InitializeComponent();

            foreach (var code in codes)
            {
                codesListBox.Items.Add(code);
            }
        }
    }
}
