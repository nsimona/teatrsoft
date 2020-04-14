﻿using System;
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
    public partial class CreateUpdateStaffPerson : Form
    {

        private void setPositionsList()
        {
            // Get all positions
            //List<Position> categoryPositions = GlobalConfig.Connection.GetPositions();
            List<Position> categoryPositions = new List<Position>{
                new Position(0, "Actor"),
                new Position(1, "Producer"),
                new Position(3, "Staff"),
            };
            categoryComboBox.DataSource = categoryPositions;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Id";
        }
        public CreateUpdateStaffPerson()
        {
            InitializeComponent();
            setPositionsList();
        }

        public CreateUpdateStaffPerson(string name, string phone, string mail, int category, string file)
        {
            InitializeComponent();
            setPositionsList();
            nameTextBox.Text = name;
            phoneTextBox.Text = phone;
            mailTextBox.Text = mail;
            categoryComboBox.SelectedValue = category;
            fileNameField.Text = file;
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

        private void AddPerson_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void archiveBtn_Click(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            if(ValidateForm())
            {

                // TODO - Improve image saving in db table

                //  byte[] photo = null;
                //  if (personPic.Text.Length > 0)
                //  {
                //    using (var stream = File.OpenRead(personPic.Text))
                //    {
                //        photo = new byte[stream.Length];
                //        stream.Read(photo, 0, photo.Length);
                //    }
                //  }

                string currentDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string sourcePath = photoField.Text;
                string directionPath = 
                    Path.Combine(
                        Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName).Parent.FullName, 
                        "PhotoLibrary\\" + photoField.AccessibleName
                    );
                File.Copy(sourcePath, directionPath, true);

                PersonModel person = new PersonModel(nameTextBox.Text, categoryComboBox.Text, phone: phoneTextBox.Text, mail: mailTextBox.Text, photo: photoField.AccessibleName);
                GlobalConfig.Connection.AddPerson(person, photoField.AccessibleName);
            }
            else
            {
                MessageBox.Show("Полетата ИМЕ и КАТЕГОРИЯ са задължителни :)");
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
            }
        }
    }
}