﻿using System;
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
        private List<PersonModel> selectedActors = new List<PersonModel>();
        private List<PersonModel> availableActors = GlobalConfig.Connection.GetMembersByCategory("Актьор");

        /* private List<PersonModel> availableActors = new List<PersonModel>()
             {
                 new PersonModel("Simona Nasteva", id: 1),
                 new PersonModel("Simeon Kashkanov", id: 2),
                 new PersonModel("Ivana  Ivanova", id: 3),
             };*/

        /*private List<PersonModel> availableDirectors = new List<PersonModel>()
            {
                new PersonModel("Simona Nasteva", id: 1),
                new PersonModel("Simeon Kashkanov", id: 2),
                new PersonModel("Ivana  Ivanova", id: 3),
            };*/
        private List<PersonModel> availableDirectors = GlobalConfig.Connection.GetMembersByCategory("Режисьор");
        private List<PorductionEventModel> addedEvents = new List<PorductionEventModel>();
        private List<SceneModel> availableScenes = new List<SceneModel>
        {
            new SceneModel("Голяма сцена"),
            new SceneModel("Зала 51"),
        };
        public void InitialLoad()
        {
            InitializeComponent();

            SetDateFormats();
            //WireUp Lists
            WireUpActors();
            WireUpDirectors();
            WireUpDates();
            WireUpScenes();
        }
        public CreateUpdateProductionForm()
        {
            InitialLoad();
        }

        public CreateUpdateProductionForm(
                List<PersonModel> selectedActors, 
                List<PorductionEventModel> addedEvents, 
                string name,
                string author,
                string description, 
                DateTime premiereDate,
                string duration, 
                int directorId,
                string fileNameField
            )
        {
            InitialLoad();
            this.selectedActors = selectedActors;
            this.addedEvents = addedEvents;
            this.nameTextBox.Text = name;
            this.authorTextBox.Text = author;
            this.descriptionTextBox.Text = description;
            this.premiereDateControl.Value = premiereDate;
            this.durationTextBox.Text = duration;
            this.directorComboBox.SelectedValue = directorId;
            this.fileNameField.Text = fileNameField;
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
            DateTime time = addDateControl.Value.ToLocalTime();
            PorductionEventModel productionEvent = new PorductionEventModel();
            productionEvent.Date = date;
            productionEvent.Time = time;
            productionEvent.Scene = ((SceneModel)addSceneComboBox.SelectedItem).Name;

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
                PorductionEventModel porductionEvent = (PorductionEventModel)listItem;
                addedEvents.Remove(porductionEvent);
            }
            WireUpDates();
        }

        private void durationTextBox_TextChanged(object sender, EventArgs e)
        {
            // TODO - Allow only numeric values
            if (!int.TryParse(durationTextBox.Text, out int result))
            {
                MessageBox.Show("Въведете продължителността на спектакъла в минути. Позволено е изпозлването само на цели числа.");
                return;
            } 
        }
    }
}
