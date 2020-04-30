using System;
using System.Drawing;
using System.IO;
using TeatrLibrary.Models;
using System.Windows.Forms;
using TeatrLibrary;
using System.Collections.Generic;

namespace TeatrUI.UserControls
{
    public partial class MemberItemControl : UserControl
    {
        List<Position> positions = GlobalConfig.Connection.GetPositions();
        PersonModel currentPerson; 
        public MemberItemControl(PersonModel person)
        {
            InitializeComponent();
            currentPerson = person;
            CustomInitialize();
        }
        private void CustomInitialize()
        {
            nameField.Text = currentPerson.Name;
            positionField.Text = positions[currentPerson.PositionId - 1].Name.ToLower();
            photoField.Image = Utils.LoadImage("staff", currentPerson.Photo);
            editBtn.Visible = currentPerson.Active;
            activateBtn.Visible = !editBtn.Visible;
        }

        public new string Name
        {
            get { return nameField.Text; }
            set { nameField.Text = value; }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new CreateUpdateStaffMember(currentPerson));
        }

        private void activateBtn_Click(object sender, EventArgs e)
        {
            currentPerson.Active = true;
            GlobalConfig.Connection.UpsertMember(currentPerson, TeatrLibrary.Enums.CrudAction.update);
            CustomInitialize();
        }
    }
}
