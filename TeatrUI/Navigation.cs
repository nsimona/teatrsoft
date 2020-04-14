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
    public partial class Navigation : Form
    {
        /*public event NavigationClickHandler NavigationClicked;
        public delegate void NavigationClickHandler(string buttonClicked);*/
        public Navigation()
        {
            InitializeComponent();
            homeNavBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            personNavBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            programNavBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            productionsNavBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            exportsNavBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            usersNavBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            personNavBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            scenesNavBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            infoBtnNav.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void selector_move(int y)
        {
            selector.Location = new Point(0, y);
        }

        private void homeNavBtn_Click(object sender, EventArgs e)
        {
            selector_move(homeNavBtn.Location.Y);
            TeatrUIEventHandler.SetMainContent(new Home());
            //NavigationClicked("home");
        }

        private void personNavBtn_Click(object sender, EventArgs e)
        {
            selector_move(personNavBtn.Location.Y);
            TeatrUIEventHandler.SetMainContent(new StaffList());
        }

        private void programNavBtn_Click(object sender, EventArgs e)
        {
            selector_move(programNavBtn.Location.Y);
            TeatrUIEventHandler.SetMainContent(new MonthProgram());
        }

        private void productionsNavBtn_Click(object sender, EventArgs e)
        {
            selector_move(productionsNavBtn.Location.Y);
            TeatrUIEventHandler.SetMainContent(new Productions());
        }

        private void exportsNavBtn_Click(object sender, EventArgs e)
        {
            selector_move(exportsNavBtn.Location.Y);
            TeatrUIEventHandler.SetMainContent(new Export());
        }

        private void usersNavBtn_Click(object sender, EventArgs e)
        {
            selector_move(usersNavBtn.Location.Y);
            TeatrUIEventHandler.SetMainContent(new Users());
        }

        private void scenesNavBtn_Click(object sender, EventArgs e)
        {
            selector_move(scenesNavBtn.Location.Y);
            TeatrUIEventHandler.SetMainContent(new ScenesPresentation());
        }

        private void infoBtnNav_Click(object sender, EventArgs e)
        {
            selector_move(infoBtnNav.Location.Y);
            TeatrUIEventHandler.SetMainContent(new Info());
        }

        private void userPhotoField_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new Account());
        }
    }
}
