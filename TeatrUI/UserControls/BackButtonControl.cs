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
    public partial class BackButtonControl : UserControl
    {
        public BackButtonControl()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.GoBack();
        }
    }
}
