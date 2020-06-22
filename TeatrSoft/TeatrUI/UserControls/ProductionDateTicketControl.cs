using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatrLibrary.Models;

namespace TeatrUI.UserControls
{
    public partial class ProductionDateTicketControl : UserControl
    {
        ProductionModel production = new ProductionModel();
        ProductionEventModel productionDate = new ProductionEventModel();
        public ProductionDateTicketControl()
        {
            InitializeComponent();
        }
        public ProductionDateTicketControl(ProductionEventModel productionDate, ProductionModel production)
        {
            InitializeComponent();
            this.production = production;
            this.productionDate = productionDate;
            ticketsBtn.Enabled = DateTime.Compare(productionDate.Date, DateTime.Now.Date) >= 0 && production.Active;
            dateLabel.Text = $"{productionDate.Date:dd.MM.yy}";
            timeField.Text = $"{productionDate.Time:hh\\:mm}";
        }

        private void ticketsBtn_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetSideContent(new ProductionSideForm(production));
            TeatrUIEventHandler.SetMainContent(new Seats(production, productionDate));
        }
    }
}
