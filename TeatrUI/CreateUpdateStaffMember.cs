using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatrLibrary;
using TeatrLibrary.DataAccess;
using TeatrLibrary.Models;

namespace TeatrUI
{
    public partial class CreateUpdateStaffMember : Form
    {
        bool photoAdded = false;
        string action = "insert";
        PersonModel currentMember = new PersonModel();

        private void CustomInitialize()
        {
            InitializeComponent();
            nameTextBox.LostFocus += new EventHandler(nameTextBox_Leave);
            setPositionsList();
        }
        public CreateUpdateStaffMember()
        {
            CustomInitialize();
            photoField.Image = new Bitmap(TeatrUI.Properties.Resources.default_member);
        }

        public CreateUpdateStaffMember(int id)
        {
            CustomInitialize();
            action = "update";
            currentMember = GlobalConfig.Connection.GetMember(id);
            nameTextBox.Text = currentMember.Name;
            phoneTextBox.Text = currentMember.Phone;
            mailTextBox.Text = currentMember.Mail;
            categoryComboBox.SelectedValue = currentMember.Position;
            fileNameField.Text = currentMember.Photo;
            photoField.Image = Utils.LoadImage("staff", currentMember.Photo);
        }

        private void setPositionsList()
        {
            List<Position> categoryPositions = GlobalConfig.Connection.GetPositions();
            categoryComboBox.DataSource = categoryPositions;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Id";
        }
        private void nameTextBox_Leave(object sender, System.EventArgs e)
        {
            if (nameTextBox.Text.Length > 0)
            {
                mailTextBox.Text = Utils.ConvertToCyrillic(nameTextBox.Text)
                .ToLower()
                .Replace(" ", ".")
                + "@teatrsoft.com";
            }
        }
        private bool ValidateForm()
        {
            if(nameTextBox.Text == "")
            {
                return false;
            }
            if (categoryComboBox.Text == "")
            {
                return false;
            }
            return true;
        }
        private void clearForm()
        {
            nameTextBox.Text = "";
            phoneTextBox.Text = "";
            mailTextBox.Text = "";
            photoField.Image = new Bitmap(TeatrUI.Properties.Resources.default_member);
            fileNameField.Text = "default.jpg";
            photoAdded = false;
        }

        private void archiveBtn_Click(object sender, EventArgs e)
        {
            currentMember.Active = false;
            GlobalConfig.Connection.UpdateMember(currentMember);
            TeatrUIEventHandler.GoBack();
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            if(ValidateForm())
            {

                // TODO - Improve image saving in db

                //  byte[] photo = null;
                //  if (personPic.Text.Length > 0)
                //  {
                //    using (var stream = File.OpenRead(personPic.Text))
                //    {
                //        photo = new byte[stream.Length];
                //        stream.Read(photo, 0, photo.Length);
                //    }
                //  }
                string memberPhotoFileName = null;
                if (photoAdded)
                {
                    memberPhotoFileName = photoField.AccessibleName;
                    string sourcePath = photoField.Text;
                    Utils.CopyImageToPhotoLibrary(sourcePath, memberPhotoFileName, directionDirectory: "staff");
                }
                currentMember.Name = nameTextBox.Text;
                currentMember.Position = (int)categoryComboBox.SelectedValue;
                currentMember.Phone = phoneTextBox.Text;
                currentMember.Mail = mailTextBox.Text;
                currentMember.Photo = memberPhotoFileName;

                if (action == "insert")
                    GlobalConfig.Connection.AddMember(currentMember);
                else if (action == "update")
                    GlobalConfig.Connection.UpdateMember(currentMember);

                clearForm();
            }
            else
            {
                MessageBox.Show("Полетата ИМЕ и КАТЕГОРИЯ са задължителни");
            }
        }

        private void personPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg; *.png)|*.jpg;*.jpeg;*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                photoField.Text = opnfd.FileName;
                photoField.Image = new Bitmap(opnfd.FileName);
                photoField.AccessibleName = opnfd.SafeFileName;
                fileNameField.Text = opnfd.SafeFileName;
                photoAdded = true;
            }
        }
    }
}
