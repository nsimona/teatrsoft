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
    public partial class TicketSideForm : Form
    {
        public TicketSideForm()
        {
            InitializeComponent();
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new Tickets());
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new Home());
            TeatrUIEventHandler.SetSideContent(new Navigation());
        }
    }
}
