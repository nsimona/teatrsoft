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
        public StaffList()
        {
            InitializeComponent();
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new CreateUpdateStaffPerson());
        }

        private void StaffList_Load(object sender, EventArgs e)
        {

        }

        private void personItemControl1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
