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
            int i = 0;
            foreach(ProductionModel production in productions)
            {
                int minWrapperHeight = new ProductionItemControl().Size.Height;
                FlowLayoutPanel wrapper = new FlowLayoutPanel();
                wrapper.Width = productionsListPanel.Width - 20;
                wrapper.Height = Math.Max(
                    minWrapperHeight, 
                    production.Dates.Count *
                    (new ProductionDateTicketControl().Size.Height + 10)
                );
                wrapper.Margin = new Padding(0, 0, 0, 30);

                FlowLayoutPanel ticketsPanel = new FlowLayoutPanel();
                ticketsPanel.Width = new ProductionDateTicketControl().Size.Width;
                ticketsPanel.Height = production.Dates.Count *
                    (new ProductionDateTicketControl().Size.Height + 10);
                foreach (ProductionEventModel productionDate in production.Dates)
                    ticketsPanel.Controls.Add(new ProductionDateTicketControl(productionDate, production));


                wrapper.Controls.Add(new ProductionItemControl(production));
                wrapper.Controls.Add(ticketsPanel);
                productionsListPanel.Controls.Add(wrapper);
                i++;
                //productionsListPanel.Controls.Add(divider);
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
