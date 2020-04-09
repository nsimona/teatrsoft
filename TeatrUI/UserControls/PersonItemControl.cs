using System;
using TeatrLibrary.Models;
using System.Windows.Forms;
namespace TeatrUI.UserControls
{
    public partial class PersonItemControl : UserControl
    {
        public PersonItemControl()
        {
            InitializeComponent();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            string name = "Simona";
            string phone = "123";
            string mail = "1234";
            int categroy = 1;
            string fileName = "filename";
            TeatrUIEventHandler.SetMainContent(new CreateUpdateStaffPerson(name, phone, mail, categroy, fileName));
        }
    }
}
