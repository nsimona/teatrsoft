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
    public partial class AddProduction : Form
    {
        AddProductionForm production = new AddProductionForm();
        public AddProduction()
        {
            InitializeComponent();
            production.TopLevel = false;
            addProductionPanel.Controls.Add(production);
            production.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in production.Controls)
            {
                
            }
            
        }
    }
}
