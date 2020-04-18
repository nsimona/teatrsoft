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
            positionField.Text = positions[currentPerson.Position - 1].Name.ToLower();
            photoField.Image = Utils.LoadImage("staff", currentPerson.Photo, "default_member");
            if (!currentPerson.Active)
            {
                editBtn.Visible = false;
                activateBtn.Visible = true;
            } else
            {
                editBtn.Visible = true;
                activateBtn.Visible = false;
            }
        }

        public new string Name
        {
            get { return nameField.Text; }
            set { nameField.Text = value; }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new CreateUpdateStaffMember(currentPerson.Id));
        }

        private void activateBtn_Click(object sender, EventArgs e)
        {
            currentPerson.Active = true;
            GlobalConfig.Connection.UpdateMember(currentPerson);
            CustomInitialize();
        }
    }
}
