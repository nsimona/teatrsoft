using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeatrUI.UserControls
{
    public partial class FooterControl : UserControl
    {
        public FooterControl()
        {
            InitializeComponent();
            currentTimeLabel.Text = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");

        }

        private void currentTimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
        }
    }
}
