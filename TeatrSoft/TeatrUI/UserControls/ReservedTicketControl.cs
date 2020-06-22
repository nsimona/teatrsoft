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
    public partial class ReservedTicketControl : UserControl
    {
        public ReservedTicketControl(string seat, decimal price)
        {
            InitializeComponent();
            seatField.Text = seat;
            priceField.Text = $"{price:0.00}";
        }
    }
}
