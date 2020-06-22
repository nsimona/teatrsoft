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
using TeatrLibrary;

namespace TeatrUI.UserControls
{
    public partial class ProductionItemControl : UserControl
    {
        ProductionModel production = new ProductionModel();
        public ProductionItemControl()
        {
            InitializeComponent();
        }
            public ProductionItemControl(ProductionModel production)
        {
            InitializeComponent();
            this.production = production;
            titleField.Text = production.Name;
            authorField.Text = production.Author;
            directorField.Text = production.DirectorName;
            durationField.Text = production.Duration.ToString() + " мин";
            posterField.Image = Utils.LoadImage("production", production.Poster);
            editBtn.Visible = production.Active;
            activateBtn.Visible = !editBtn.Visible;
        }


        private void posterField_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new ProductionDescription(production));
            TeatrUIEventHandler.SetSideContent(new ProductionSideForm(production));
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new CreateUpdateProduction(production));
        }

        private void activateBtn_Click(object sender, EventArgs e)
        {
            production.Active = true;
            editBtn.Visible = production.Active;
            activateBtn.Visible = !editBtn.Visible;
            GlobalConfig.Connection.UpsertProduction(production, TeatrLibrary.Enums.CrudAction.update);
        }
    }
}
