using System;
using System.Windows.Forms;

namespace TeatrUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            errorInfo.Visible = false;
        }

        private bool validate()
        {
            return true;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                this.Hide();
                Form dashboard = new TeatrSoft();
                dashboard.Closed += (s, args) => this.Close();
                dashboard.Show();
            }
            else
                errorInfo.Visible = true;
        }
    }
}
