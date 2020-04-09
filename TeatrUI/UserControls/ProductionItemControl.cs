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
    public partial class ProductionItemControl : UserControl
    {
        public ProductionItemControl()
        {
            InitializeComponent();
        }

        private void posterField_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new ProductionDescription());
            TeatrUIEventHandler.SetSideContent(new ProductionSideForm());
        }

        private void eidtBtn_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new CreateUpdateProduction());
        }
    }
}
