using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatrLibrary;
using TeatrLibrary.Models;
using TeatrUI.UserControls;

namespace TeatrUI
{
    public partial class Productions : Form
    {
        List<ProductionModel> productions = new List<ProductionModel>();
        public Productions()
        {
            InitializeComponent();
            productions = GlobalConfig.Connection.GetAllProductions();
            foreach(ProductionModel production in productions)
            {
                FlowLayoutPanel ticketsPanel = new FlowLayoutPanel();
                ticketsPanel.Width = new ProductionDateTicketControl().Size.Width;
                ticketsPanel.Height = production.Dates.Count * 
                    new ProductionDateTicketControl().Size.Height + 30;

                productionsListPanel.Controls.Add(new ProductionItemControl(production));
                productionsListPanel.Controls.Add(ticketsPanel);
                foreach(ProductionEventModel productionDate in production.Dates) {
                    ticketsPanel.Controls.Add(new ProductionDateTicketControl(productionDate, production));
                }
            }
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new CreateUpdateProduction());
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {

        }

        private void productionItemControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
