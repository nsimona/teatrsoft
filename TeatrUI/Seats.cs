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
    public partial class Seats : Form
    {
        public Seats()
        {
            InitializeComponent();
            IniitalSeats();
        }

        public void IniitalSeats()
        {
            busySeatControl.SeatColor = Color.FromArgb(253, 101, 101);
            selectedSeatControl.SeatColor = Color.FromArgb(107, 216, 180);
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetSideContent(new TicketSideForm());
            TeatrUIEventHandler.SetMainContent(new Tickets());
        }
    }
}
