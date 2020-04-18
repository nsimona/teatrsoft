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
{
    public  partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            TeatrUIEventHandler.SetMainContent = (Form f) =>
            {

                if(TeatrUIEventHandler.ContentHistory.Count == 10)
                    TeatrUIEventHandler.ContentHistory.RemoveAt(0);
                TeatrUIEventHandler.ContentHistory.Add(f);
                contentPanel.Controls.Clear();
                f.TopLevel = false;
                contentPanel.Controls.Add(f);
                f.Show();
            };

            TeatrUIEventHandler.SetSideContent = (Form f) =>
            {
                if (TeatrUIEventHandler.SideHistory.Count == 10)
                    TeatrUIEventHandler.SideHistory.RemoveAt(0);
                TeatrUIEventHandler.SideHistory.Add(f);
                sidePanel.Controls.Clear();
                f.TopLevel = false;
                sidePanel.Controls.Add(f);
                f.Show();
            };

            TeatrUIEventHandler.GoBack = () =>
            {
                Form lastVisitedMainForm = TeatrUIEventHandler.ContentHistory[TeatrUIEventHandler.ContentHistory.Count - 2];
                TeatrUIEventHandler.ContentHistory.RemoveAt(TeatrUIEventHandler.ContentHistory.Count - 1);
                TeatrUIEventHandler.SetMainContent(lastVisitedMainForm);
                TeatrUIEventHandler.ContentHistory.RemoveAt(TeatrUIEventHandler.ContentHistory.Count - 1);
                if (TeatrUIEventHandler.SideHistory.Count > 1) {
                    Form lastVisitedSideForm = TeatrUIEventHandler.SideHistory[TeatrUIEventHandler.SideHistory.Count - 2];
                    TeatrUIEventHandler.SideHistory.RemoveAt(TeatrUIEventHandler.SideHistory.Count - 1);
                    TeatrUIEventHandler.SetSideContent(lastVisitedSideForm);
                    TeatrUIEventHandler.SideHistory.RemoveAt(TeatrUIEventHandler.SideHistory.Count - 1);
                }
            };

            Navigation navigation = new Navigation();
            TeatrUIEventHandler.SetSideContent(navigation);

            Home home = new Home();
            TeatrUIEventHandler.SetMainContent(home);
        }
    }
}
