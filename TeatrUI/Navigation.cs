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
        public event NavigationClickHandler NavigationClicked;
        public delegate void NavigationClickHandler(string buttonClicked);
        public Navigation()
        {
            InitializeComponent();
        }

        private void selector_move(int y)
        {
            selector.Location = new Point(0, y);
        }

        private void homeNavBtn_Click(object sender, EventArgs e)
        {
            selector_move(homeNavBtn.Location.Y);
            NavigationClicked("home");
        }

        private void personNavBtn_Click(object sender, EventArgs e)
        {
            selector_move(personNavBtn.Location.Y);
            NavigationClicked("staffMembers");
        }

        private void programNavBtn_Click(object sender, EventArgs e)
        {
            selector_move(programNavBtn.Location.Y);
            NavigationClicked("program");
        }

        private void productionsNavBtn_Click(object sender, EventArgs e)
        {
            selector_move(productionsNavBtn.Location.Y);
            NavigationClicked("productions");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exportsNavBtn_Click(object sender, EventArgs e)
        {
            selector_move(exportsNavBtn.Location.Y);
            NavigationClicked("exports");
        }

        private void usersNavBtn_Click(object sender, EventArgs e)
        {
            selector_move(usersNavBtn.Location.Y);
            NavigationClicked("users");
        }

        private void scenesNavBtn_Click(object sender, EventArgs e)
        {
            selector_move(scenesNavBtn.Location.Y);
            NavigationClicked("scenes");
        }

        private void infoBtnNav_Click(object sender, EventArgs e)
        {
            selector_move(infoBtnNav.Location.Y);
            NavigationClicked("info");
        }
    }
}
