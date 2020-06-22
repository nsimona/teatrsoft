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
    public partial class Home : Form
    {
        List<ProductionEventModel> todays = GlobalConfig.Connection.GetTodaysPlays();
        List<ProductionEventModel> tormorrows = GlobalConfig.Connection.GetTomorrowsPlays();
        public Home()
        {
            InitializeComponent();
        }
        private void Home_Load(object sender, EventArgs e)
        {
            todayField.Text = DateTime.Now.ToString("dd.MM.yyyy");
            tomorrowField.Text = DateTime.Now.AddDays(1).ToString("dd.MM.yyyy");
            LoadPlays(todays, todayPanel);
            LoadPlays(tormorrows, tomorrowPanel);
        }

        private void LoadPlays (List<ProductionEventModel> plays, FlowLayoutPanel panel)
        {
            foreach (ProductionEventModel e in plays)
            {
                ProductionHomeItem item = new ProductionHomeItem();
                item.Title = e.ProductionName;
                item.Scene = e.SceneName;
                item.Start = $"{e.Time:hh\\:mm}";
                item.Poster = e.Poster;
                panel.Controls.Add(item);
            }
        }
    }
}
