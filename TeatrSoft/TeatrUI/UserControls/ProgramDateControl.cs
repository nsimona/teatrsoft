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
    public partial class ProgramDateControl : UserControl
    {
        public ProgramDateControl()
        {
            InitializeComponent();
        }

        public string Date
        {
            get { return dateField.Text; }
            set { dateField.Text = value; }
        }
        public string Day
        {
            get { return dayLabel.Text; }
            set { dayLabel.Text = value; }
        }
    }
}
