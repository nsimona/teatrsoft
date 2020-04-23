using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatrLibrary.Models;
using TeatrUI.UserControls;

namespace TeatrUI
{
    public partial class ProductionDescription : Form
    {
        public ProductionDescription(ProductionModel production)
        {
            InitializeComponent();
            descriptionBox.Text = production.Description;
            foreach(ProductionEventModel productionEvent in production.Dates)
            {
                datesPanel.Controls.Add(new ProductionDateTicketControl(productionEvent, production));
            }
        }
    }
}
