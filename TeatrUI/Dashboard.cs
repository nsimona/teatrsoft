using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace TeatrUI
{/**/
    public  partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            TeatrUIEventHandler.SetMainContent = (Form f) =>
            {
                contentPanel.Controls.Clear();
                f.TopLevel = false;
                contentPanel.Controls.Add(f);
                f.Show();
                TeatrUIEventHandler.ContentHistory.Add(f);
            };

            TeatrUIEventHandler.SetSideContent = (Form f) =>
            {
                sidePanel.Controls.Clear();
                f.TopLevel = false;
                sidePanel.Controls.Add(f);
                f.Show();
                TeatrUIEventHandler.SideHistory.Add(f);
            };

            TeatrUIEventHandler.GoBack = () =>
            {
                List<Form> ContentHistory = TeatrUIEventHandler.ContentHistory;
                List<Form> SideHistory = TeatrUIEventHandler.SideHistory;
                Form lastVisitedMainForm = ContentHistory[ContentHistory.Count - 1];
                Form lastVisitedSideForm = SideHistory[SideHistory.Count - 1];
                SideHistory.RemoveAt(SideHistory.Count - 1);
                ContentHistory.RemoveAt(ContentHistory.Count - 1);

                TeatrUIEventHandler.SetMainContent(lastVisitedMainForm);
                TeatrUIEventHandler.SetSideContent(lastVisitedSideForm);
            };

            Navigation navigation = new Navigation();
            TeatrUIEventHandler.SetSideContent(navigation);

            Home home = new Home();
            TeatrUIEventHandler.SetMainContent(home);
        }
    }
}
