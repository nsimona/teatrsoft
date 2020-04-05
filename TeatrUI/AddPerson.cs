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
    public partial class AddPerson : Form
    {
        public AddPerson()
        {
            InitializeComponent();
            // Get all positions
            List<Position> categoryPositions = GlobalConfig.Connection.GetPositions();
            category.DataSource = new BindingSource(categoryPositions, null);
            category.DisplayMember = "Name";
            category.ValueMember = "Id";

        }

        private bool ValidateForm()
        {
            if(name.Text == "")
            {
                return false;
            }
            if (category.Text == "")
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
                string sourcePath = personPic.Text;
                string directionPath = 
                    Path.Combine(
                        Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName).Parent.FullName, 
                        "PhotoLibrary\\" + personPic.AccessibleName
                    );
                File.Copy(sourcePath, directionPath, true);

                PersonModel person = new PersonModel(name.Text, category.Text, phone.Text, mail.Text, personPic.AccessibleName);
                GlobalConfig.Connection.AddPerson(person, personPic.AccessibleName);
            }
            else
            {
                MessageBox.Show("Полетата ИМЕ и КАТЕГОРИЯ са задължителни :)");
            }
        }

        private void personPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                personPic.Text = opnfd.FileName;
                personPic.Image = new Bitmap(opnfd.FileName);
                personPic.AccessibleName = opnfd.SafeFileName;
            }
        }
    }
}
