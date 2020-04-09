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
    public partial class SeatControl : UserControl
    {
        bool selected = false;
        public SeatControl()
        {
            InitializeComponent();
        }

        public Color SeatColor
        {
            get { return seatBox.BackColor; }
            set { seatBox.BackColor = value; }
        }

        private void seatBox_Click(object sender, EventArgs e)
        {
            if(selected)
            {
                seatBox.BackColor = Color.FromArgb(200, 200, 200);
                selected = false;
            } else
            {
                seatBox.BackColor = Color.FromArgb(107, 216, 180);
                selected = true;
            }
        }
    }
}
