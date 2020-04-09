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
    public partial class Productions : Form
    {
        public Productions()
        {
            InitializeComponent();
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new CreateUpdateProduction());
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {

        }

        private void productionItemControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
