using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inductance_calculation
{
    public partial class Graphs_inductanc_form : Form
    {
        public Graphs_inductanc_form()
        {
            InitializeComponent();

            checkedListBox1.SetItemChecked(0, true);
            checkedListBox1.GetItemChecked(0);

            checkedListBox1.SetItemChecked(1, true);
            checkedListBox1.GetItemChecked(1);

            checkedListBox1.SetItemChecked(2, true);
            checkedListBox1.GetItemChecked(2);

            checkedListBox1.SetItemChecked(3, true);
            checkedListBox1.GetItemChecked(3);
        }
    }
}
