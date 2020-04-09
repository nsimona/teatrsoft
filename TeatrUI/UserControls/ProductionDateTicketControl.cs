﻿using System;
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
    public partial class ProductionDateTicketControl : UserControl
    {
        public ProductionDateTicketControl()
        {
            InitializeComponent();
        }

        private void ticketsBtn_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetSideContent(new ProductionSideForm());
            TeatrUIEventHandler.SetMainContent(new Seats());
        }
    }
}
