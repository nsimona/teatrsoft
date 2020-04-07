using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeatrUI
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void editPhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                photoField.Text = opnfd.FileName;
                photoField.Image = new Bitmap(opnfd.FileName);
                photoField.AccessibleName = opnfd.SafeFileName;
            }
        }
    }
}
