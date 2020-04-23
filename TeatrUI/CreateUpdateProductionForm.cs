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
    public partial class CreateUpdateProductionForm : Form
    {
        //Added Actors List
        private List<PersonModel> availableActors = GlobalConfig.Connection.GetAvailableActors();
        private List<PersonModel> availableDirectors = GlobalConfig.Connection.GetMembersByCategory("Режисьор");
        private List<SceneModel> availableScenes = GlobalConfig.Connection.GetScenes();
        public List<PersonModel> selectedActors = new List<PersonModel>();
        public List<ProductionEventModel> addedEvents = new List<ProductionEventModel>();
        public void InitialLoad()
        {
            InitializeComponent();

            SetDateFormats();
            DateTime now = DateTime.Now;
            addTimeControl.Value = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second, now.Kind); ;
        }
        public CreateUpdateProductionForm()
        {
            InitialLoad();
            WireUpActors();
            WireUpDirectors();
            WireUpDates();
            WireUpScenes();
        }

        public CreateUpdateProductionForm(ProductionModel production)
        {
            InitialLoad();
            this.nameTextBox.Text = production.Name;
            this.authorTextBox.Text = production.Author;
            this.descriptionTextBox.Text = production.Description;
            this.premiereDateControl.Value = production.Premiere;
            this.durationTextBox.Text = $"{production.Duration}";
            this.directorComboBox.SelectedValue = production.Director;
            this.posterField.Image = Utils.LoadImage("production", production.PosterFileName);
            posterField.AccessibleName = production.PosterFileName;
            posterField.Text = production.PosterFileName;
            this.fileNameField.Text = production.PosterFileName;
            this.selectedActors = production.Actors;
            this.addedEvents = production.Dates;
            availableActors = GlobalConfig.Connection.GetAvailableActors(production.Id);
            WireUpActors();
            WireUpDirectors();
            WireUpDates();
            WireUpScenes();
        }

        public void ResetAllControls()
        {
            nameTextBox.Text = "";
            premiereDateControl.Value = DateTime.Now;
            authorTextBox.Text = "";
            directorComboBox.SelectedIndex = 0;
            durationTextBox.Text = "0";
            selectedActors = new List<PersonModel>();
            addedEvents = new List<ProductionEventModel>();
            descriptionTextBox.Text = "";
            posterField.Image = Utils.LoadImage("production", null);
            fileNameField.Text = "default.jpg";
            WireUpActors();
            WireUpDates();
        }
        private void SetDateFormats()
        {
            premiereDateControl.Format = DateTimePickerFormat.Custom;
            premiereDateControl.CustomFormat = "dd/MM/yyyy";
            addDateControl.Format = DateTimePickerFormat.Custom;
            addDateControl.CustomFormat = "dd/MM/yyyy";
        }
        private void WireUpActors()
        {
            actorsComboBox.DataSource = null;
            actorsComboBox.DataSource = availableActors;
            actorsComboBox.DisplayMember = "Name";
            actorsComboBox.ValueMember = "Id";

            actorsList.DataSource = null;
            actorsList.DataSource = selectedActors;
            actorsList.DisplayMember = "Name";
            actorsList.ValueMember = "Id";
        }

        private void WireUpDirectors()
        {
            directorComboBox.DataSource = availableDirectors;
            directorComboBox.DisplayMember = "Name";
            directorComboBox.ValueMember = "Id";
        }

        private void WireUpDates()
        {
            datesList.DataSource = null;
            datesList.DataSource = addedEvents;
            datesList.DisplayMember = "FullEventDescription";
        }

        private void WireUpScenes()
        {
            addSceneComboBox.DataSource = null;
            addSceneComboBox.DataSource = availableScenes;
            addSceneComboBox.DisplayMember = "Name";
            addSceneComboBox.ValueMember = "Id";
        }

        private void posterField_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.png;)|*.jpg;*.jpeg;*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                posterField.Text = opnfd.FileName;
                posterField.Image = new Bitmap(opnfd.FileName);
                posterField.AccessibleName = opnfd.SafeFileName;
                fileNameField.Text = opnfd.SafeFileName;
            }
        }

        private void addActorBtn_Click(object sender, EventArgs e)
        {
            PersonModel person = (PersonModel)actorsComboBox.SelectedItem;
            availableActors.Remove(person);
            selectedActors.Add(person);
            WireUpActors();
        }

        private void AddProductionForm_Load(object sender, EventArgs e)
        {

        }

        private void delActorBtn_Click(object sender, EventArgs e)
        {
            foreach(object listItem in actorsList.SelectedItems)
            {
                PersonModel person = (PersonModel)listItem;
                selectedActors.Remove(person);
                availableActors.Add(person);
            }
            WireUpActors();
        }

        private void addDateBtn_Click(object sender, EventArgs e)
        {
            DateTime date = addDateControl.Value.Date;
            TimeSpan time = addTimeControl.Value.TimeOfDay;
            ProductionEventModel productionEvent = new ProductionEventModel();
            productionEvent.Date = date;
            productionEvent.Time = time;
            productionEvent.Scene = ((SceneModel)addSceneComboBox.SelectedItem).Id;
            productionEvent.SceneName = availableScenes.Find(scene => scene.Id == productionEvent.Scene).Name;

            if(durationTextBox.TextLength == 0)
            {
                MessageBox.Show("За да добавите дата е необходимо да добавите продължителност на спектакъла.");
                durationTextBox.Focus();
                return;

            }
            if (EventDuplicate())
            {
                MessageBox.Show("Не е възможно добавянето на тази дата/час.\nВече сте запазили сцената за този времеви интервал.");
                return;
            }
            addedEvents.Add(productionEvent);
            WireUpDates();
        }

        private bool EventDuplicate()
        {
            //TODO - check in the db if the scene is reserved for this time period
            return false;
        }

        private void delDateBtn_Click(object sender, EventArgs e)
        {
            foreach (object listItem in datesList.SelectedItems)
            {
                ProductionEventModel porductionEvent = (ProductionEventModel)listItem;
                addedEvents.Remove(porductionEvent);
            }
            WireUpDates();
        }

        private void durationTextBox_TextChanged(object sender, EventArgs e)
        {
            // TODO - Allow only numeric values
            if (!short.TryParse(durationTextBox.Text, out short result))
            {
                MessageBox.Show("Въведете продължителността на спектакъла в минути. Позволено е изпозлването само на цели числа.");
                return;
            } 
        }
    }
}
