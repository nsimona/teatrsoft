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
    public partial class Seats : Form
    {
        ProductionModel production = new ProductionModel();
        ProductionEventModel productionDate = new ProductionEventModel();
        SceneModel scene = new SceneModel();
        int selectedSeats;
        public Seats(ProductionModel production, ProductionEventModel productionDate)
        {
            InitializeComponent();
            InitializeStaticSeats();
            this.productionDate = productionDate;
            scene = GlobalConfig.Connection.GetScene(productionDate.Scene);
            dateField.Text = $"{productionDate.Date.Date:dd.MM.yy}";
            sceneField.Text = productionDate.SceneName.ToUpper();
            freeSeatsField.Text = $"{productionDate.SoldTickets} / СВОБОДНИ МЕСТА";
            drawSeats();
        }

        public void InitializeStaticSeats()
        {
            busySeatControl.SeatColor = Color.FromArgb(253, 101, 101);
            selectedSeatControl.SeatColor = Color.FromArgb(107, 216, 180);
        }

        private void drawSeats()
        {
            for (int i = 0; i < scene.Model.GetLength(0); i++)
            {
                FlowLayoutPanel row = new FlowLayoutPanel();
                row.Width = modelPanel.Width;
                row.Height = 24;

                modelPanel.Controls.Add(row);
                for (int j = 0; j < scene.Model.GetLength(1); j++)
                {
                    if (scene.Model[i, j] == 1)
                    {
                        row.Controls.Add(new SeatControl());
                    }
                    else
                    {
                        Label empty = new Label();
                        empty.Width = 21;
                        empty.Height = 21;
                        row.Controls.Add(empty);
                    }
                }
            }
        }
        private void continueBtn_Click(object sender, EventArgs e)
        {
            TeatrUIEventHandler.SetSideContent(new TicketSideForm());
            TeatrUIEventHandler.SetMainContent(new Tickets());
        }

        private void scenePanel_Paint_1(object sender, PaintEventArgs e)
        {
            Pen teatrGreenPen = new Pen(Color.FromArgb(107, 216, 180), 2);
            Graphics g = scenePanel.CreateGraphics();
            g.DrawArc(teatrGreenPen, 0, 0, scenePanel.Width, scenePanel.Height + 30, 0, -180);
        }

        private void p_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
