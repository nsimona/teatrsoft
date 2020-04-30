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
using static TeatrLibrary.Structs;

namespace TeatrUI
{
    public partial class TicketSideForm : Form
    {
        List<Seat> seats = new List<Seat>();
        ProductionModel production = new ProductionModel();
        ProductionEventModel productionDate = new ProductionEventModel();
        SceneModel scene = new SceneModel();
        public TicketSideForm(ProductionModel production, List<Seat> seats, ProductionEventModel productionDate, SceneModel scene)
        {
            InitializeComponent();
            this.production = production;
            this.seats = seats;
            this.productionDate = productionDate;
            this.scene = scene;
            titleField.Text = production.Name;
            authorField.Text = production.Author;
            directorField.Text = production.DirectorName;
            actorsField.Text = string.Join(", ", production.Actors.Select(x => x.Name));
            durationField.Text = $"{production.Duration} мин";
            dateField.Text = $"{productionDate.Date:dd.MM.yy}";
            sceneField.Text = productionDate.SceneName;
            //TODO all structs should be common
            foreach(Seat s in seats)
                seatsPanel.Controls.Add(new ReservedTicketControl(s.ToString(), scene.Price));
            totalField.Text = $"{(seats.Count * scene.Price):0.00} лв";
        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            payBtn.Enabled = false;
            GlobalConfig.Connection.ReserveTickets(productionDate, seats);
            TeatrUIEventHandler.SetMainContent(new Tickets(production, seats, productionDate, scene));
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetMainContent(new Home());
            TeatrUIEventHandler.SetSideContent(new Navigation());
        }
    }
}
