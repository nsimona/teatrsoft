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
using static TeatrUI.Enums;

namespace TeatrUI
{
    public partial class CreateUpdateProduction : Form
    {
        CreateUpdateProductionForm productionForm = new CreateUpdateProductionForm();
        ProductionModel production = new ProductionModel();
        CrudAction action = CrudAction.create;
        public CreateUpdateProduction()
        {
            InitializeComponent();
            productionForm.TopLevel = false;
            addProductionPanel.Controls.Add(productionForm);
            productionForm.Show();
        }
        public CreateUpdateProduction(ProductionModel production)
        {
            InitializeComponent();
            action = CrudAction.update;
            this.production = production;
            productionForm = new CreateUpdateProductionForm(production);
            productionForm.TopLevel = false;
            addProductionPanel.Controls.Add(productionForm);
            productionForm.Show();
        }
        private bool ValidateForm()
        {
            if (production.Name == "") return false;
            if (production.Duration == 0) return false;
            return true;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            string name = productionForm.Controls.Find("nameTextBox", true)[0].Text;
            DateTime premiere = ((DateTimePicker)productionForm.Controls.Find("premiereDateControl", true)[0]).Value;
            string author = productionForm.Controls.Find("authorTextBox", true)[0].Text;
            short duration = 0;
            short.TryParse((productionForm.Controls.Find("durationTextBox", true)[0].Text), out duration);
            int director = (int)((ComboBox)productionForm.Controls.Find("directorComboBox", true)[0]).SelectedValue;
            string description = productionForm.Controls.Find("descriptionTextBox", true)[0].Text;
            string posterFileName = productionForm.Controls.Find("posterField", true)[0].AccessibleName;
            string sourceFile = productionForm.Controls.Find("posterField", true)[0].Text;
            List<PersonModel> actors = productionForm.selectedActors;
            List<ProductionEventModel> dates = productionForm.addedEvents;

            production.Name = name;
            production.Premiere = premiere;
            production.Author = author;
            production.Duration = duration;
            production.Director = director;
            production.Description = description;
            production.PosterFileName = posterFileName;
            production.Actors = actors;
            production.Dates = dates;
                
            if (posterFileName != null)
                Utils.CopyImageToPhotoLibrary(sourceFile, posterFileName, "production");
            if (ValidateForm())
            {
                switch(action)
                {
                    case CrudAction.create:
                        GlobalConfig.Connection.AddProduction(production);
                        productionForm.ResetAllControls();
                        break;
                    case CrudAction.update:
                        GlobalConfig.Connection.UpdateProduction(production);
                        TeatrUIEventHandler.GoBack();
                        break;
                }
            }
                
            else
                MessageBox.Show("Полетата име и продължителност са задължителни");
        }

        private void archiveBtn_Click(object sender, EventArgs e)
        {
            production.Active = false;
            GlobalConfig.Connection.UpdateProduction(production);
            TeatrUIEventHandler.GoBack();
        }
    }
}
