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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            // Handle navigation
            Navigation navigation = new Navigation();
            navigation.TopLevel = false;
            sidePanel.Controls.Add(navigation);
            navigation.Show();
            navigation.NavigationClicked += navigationButtonClicked;
            // Handle init content
            Home home = new Home();
            loadContent(home);
        }

        private void loadContent(Form form)
        {
            contentPanel.Controls.Clear();
            form.TopLevel = false;
            contentPanel.Controls.Add(form);
            form.Show();
        }
        private void navigationButtonClicked(string clickedButton)
        {
            switch (clickedButton)
            {
                case "home":
                    Home home = new Home();
                    loadContent(home);
                    break;
                case "program":
                    MonthProgram monthProgram= new MonthProgram();
                    loadContent(monthProgram);
                    break;
                case "productions":
                    Productions productions = new Productions();
                    AddProduction addProduction = new AddProduction();
                    loadContent(productions);
                    productions.OnAddButtonClicked += (object sender, EventArgs e) => loadContent(addProduction);
                    break;
                case "exports":
                    Export export = new Export();
                    loadContent(export);
                    break;
                case "staffMembers":
                    StaffList staffList = new StaffList();
                    AddPerson addPerson = new AddPerson();
                    loadContent(staffList);
                    staffList.OnAddButtonClicked += (object sender, EventArgs e) => loadContent(addPerson);
                    break;
                case "users":
                    Users users = new Users();
                    loadContent(users);
                    break;
                case "scenes":
                    ScenesPresentation scenes = new ScenesPresentation();
                    loadContent(scenes);
                    break;
                case "info":
                    Info info = new Info();
                    loadContent(info);
                    break;
            }


        }
        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
