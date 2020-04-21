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
    public partial class ProductionItemControl : UserControl
    {
        ProductionModel production = new ProductionModel();
        public ProductionItemControl(ProductionModel production)
        {
            InitializeComponent();
            this.production = production;
            CustomInitialize();
        }

        private void CustomInitialize() {
            titleField.Text = production.Name;
            authorField.Text = production.Author;
            directorField.Text = production.DirectorName;
            durationField.Text = production.Duration.ToString() + " мин";
            posterField.Image = Utils.LoadImage("production", production.PosterFileName);
            actionBtn.Visible = production.Active;
        }

        private void posterField_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new ProductionDescription(production));
            TeatrUIEventHandler.SetSideContent(new ProductionSideForm(production));
        }

        private void actionBtn_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new CreateUpdateProduction(production));
        }
    }
}
