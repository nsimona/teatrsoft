using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TeatrLibrary.Structs;

namespace TeatrUI.UserControls
{
    public partial class SeatControl : UserControl
    {
        bool selected = false;
        int row;
        int column;
        public event SeatBoxClickHandler OnSeatBoxClick;
        public delegate void SeatBoxClickHandler(bool selected, int row, int column);
        public SeatControl()
        {
            InitializeComponent();
        }
        public SeatControl(int row, int column)
        {
            InitializeComponent();
            this.row = row;
            this.column = column;
            Seat seat = new Seat(row, column);
            tooltip.SetToolTip(seatBox, seat.ToString());
        }
        public void SetAsTaken()
        {
            seatBox.Enabled = false;
            seatBox.BackColor = Color.FromArgb(253, 101, 101);
        }
        public Color SeatColor
        {
            get { return seatBox.BackColor; }
            set { seatBox.BackColor = value; }
        }
        public void setSize(int size)
        {
            seatBox.Width = size;
            seatBox.Height = size;
            this.Size = new Size(size, size);
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

            OnSeatBoxClick(selected, row, column);
        }
    }
}
