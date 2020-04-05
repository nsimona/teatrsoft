using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeatrUI
{
    public partial class StaffList : Form
    {
        public event EventHandler OnAddButtonClicked;
        public StaffList()
        {
            InitializeComponent();
        }

        private void personItemControl1_Load(object sender, EventArgs e)
        {

        }

        private void addNew_Click(object sender, EventArgs e)
        {
            OnAddButtonClicked(sender, e);
        }

        private void StaffList_Load(object sender, EventArgs e)
        {

        }
    }
}
