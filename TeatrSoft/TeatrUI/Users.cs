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

namespace TeatrUI
{
    public partial class Users : Form
    {
        List<RoleModel> roles = GlobalConfig.Connection.GetRoles();
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = roles;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "Id";
        }
        private bool validate()
        {
            if (nameTextBox.Text == "" || passTextBox.Text == "" || mailTextBox.Text == "") return false;
            return true;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                UserModel user = new UserModel();
                user.Name = nameTextBox.Text;
                user.Password = passTextBox.Text;
                user.Mail = mailTextBox.Text;
                user.RoleId = (int)categoryComboBox.SelectedValue;
                GlobalConfig.Connection.CreatUser(user);
            } else
                MessageBox.Show("Всички полета са задължителни");
        }
    }
}
