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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void mainProductionItem2_Load(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            todayField.Text = DateTime.Now.ToString("dd.MM.yyyy");
            tomorrowField.Text = DateTime.Now.AddDays(1).ToString("dd.MM.yyyy");
        }

        private void pageTitle_Click(object sender, EventArgs e)
        {

        }

        private void todayField_Click(object sender, EventArgs e)
        {

        }
    }
}
