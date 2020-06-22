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
using TeatrUI.UserControls;

namespace TeatrUI
{
    public partial class StaffList : Form
    {
        List<PersonModel> staffMembers = GlobalConfig.Connection.GetAllMembers();
        bool sorted = false;
        public StaffList()
        {
            InitializeComponent();
            setMemberList();
        }
         private void setMemberList()
        {
            staffPanel.Controls.Clear();
            foreach (PersonModel member in staffMembers)
            {
                staffPanel.Controls.Add(new MemberItemControl(member));
            }
        }
        private void addNew_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new CreateUpdateStaffMember());
        }

        private void StaffList_Load(object sender, EventArgs e)
        {

        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            staffPanel.Controls.Clear();
            if(!sorted)
            {
                staffMembers = staffMembers.OrderBy(x => x.Name).ToList();
                sorted = true;
            }else
                staffMembers.Reverse();
            setMemberList();
            /*staffMembers = GlobalConfig.Connection.GetAllMembers(sort);
            setMemberList();
            sort = sort == "asc" ? "desc" : "asc";*/

        }
    }
}
