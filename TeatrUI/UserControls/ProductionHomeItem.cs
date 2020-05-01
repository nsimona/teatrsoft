using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeatrUI.UserControls
{
    public partial class ProductionHomeItem : UserControl
    {
        public ProductionHomeItem()
        {
            InitializeComponent();
        }
        public string Scene
        {
            get { return sceneField.Text; }
            set { sceneField.Text = value; }
        }
        public string Title
        {
            get { return titleField.Text; }
            set { titleField.Text = value; }
        }
        public string Poster
        {
            get { return posterField.Text; }
            set { posterField.Image = Utils.LoadImage("production", value); }
        }
        public string Start
        {
            get { return timeField.Text; }
            set { timeField.Text = value; }
        }

        //private void posterField_Click(object sender, EventArgs e)
        //{
        //    TeatrUIEventHandler.SetMainContent(new ProductionDescription());
        //    TeatrUIEventHandler.SetSideContent(new ProductionSideForm());
        //}
    }
}
