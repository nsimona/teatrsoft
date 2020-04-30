using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TeatrLibrary;
using TeatrLibrary.Models;
using TeatrUI.UserControls;
using static TeatrLibrary.Structs;

namespace TeatrUI
{
    public partial class Seats : Form
    {
        ProductionModel production = new ProductionModel();
        ProductionEventModel productionDate = new ProductionEventModel();
        SceneModel scene = new SceneModel();
        int seatMargin = 4;
        List<Seat> selectedSeats = new List<Seat>();
        public Seats(ProductionModel production, ProductionEventModel productionDate)
        {
            InitializeComponent();
            InitializeStaticSeats();
            this.production = production;
            this.productionDate = productionDate;
            scene = GlobalConfig.Connection.GetScene(productionDate.SceneId);
            dateField.Text = $"{productionDate.Date.Date:dd.MM.yy}";
            sceneField.Text = productionDate.SceneName.ToUpper();
            int freeSeats = scene.SeatsCount - productionDate.SoldTickets;
            freeSeatsField.Text = $"{freeSeats}/{scene.SeatsCount} СВОБОДНИ МЕСТА";
            drawSeats();
        }
        public void updateSelectedSeats()
        {
            selectedField.Text = string.Join(" ", selectedSeats); ;
            sumField.Text = $"{(selectedSeats.Count * scene.Price):0.00} лв";
        }
        public void InitializeStaticSeats()
        {
            busySeatControl.SeatColor = Color.FromArgb(253, 101, 101);
            selectedSeatControl.SeatColor = Color.FromArgb(107, 216, 180);
        }
        public void OnSeatBoxClick(bool selected, int row, int column)
        {
            Seat seat = new Seat(row, column);
            if (selected) 
                selectedSeats.Add(seat);
            else
            {
                Seat existingSeat = selectedSeats.Find(item => item.Row == row && item.Column == column);
                selectedSeats.Remove(existingSeat);
            }
            updateSelectedSeats();
        }
        private int calculateSeatSize()
        {
            int minSize = 18;
            int rows = scene.Schema.GetLength(0);
            int cols = scene.Schema.GetLength(1);
            int maxHeight = (modelPanel.Height / rows) - (2 * seatMargin);
            int maxWidth = (modelPanel.Width / cols) - (2 * seatMargin);
            int maxSize = Math.Min(maxWidth, maxHeight);
            int size = Math.Max(maxSize, minSize);
            return size;
        }

        private void drawSeats()
        {
            int size = calculateSeatSize();
            for (int i = 0; i < scene.Schema.GetLength(0); i++)
            {
                int seatSize = size;
                FlowLayoutPanel row = new FlowLayoutPanel();
                int rowSize = scene.Schema.GetLength(1) * (seatSize + (2* seatMargin));
                row.Width = rowSize;
                row.Height = seatSize + (2 * seatMargin);
                int modelPanelWidth = modelPanel.Width - (modelPanel.Margin.Left + modelPanel.Margin.Right);
                row.Margin = new Padding(Math.Max((modelPanelWidth - rowSize) / 2, 0), 0, 0, 0);

                modelPanel.Controls.Add(row);
                for (int j = 0; j < scene.Schema.GetLength(1); j++)
                {
                    if (scene.Schema[i, j] == 1)
                    {
                        SeatControl seat = new SeatControl(i, j);
                        if(Utils.SeatIsTaken(productionDate.ReservedSeatsList, new Seat(i, j)))
                           seat.SetAsTaken();
                        seat.setSize(size);
                        seat.Margin = new Padding(seatMargin);
                        seat.OnSeatBoxClick += OnSeatBoxClick;
                        row.Controls.Add(seat);

                    }
                    else
                    {
                        Label empty = new Label();
                        empty.Width = size;
                        empty.Height = size;
                        empty.Margin = new Padding(seatMargin);
                        row.Controls.Add(empty);
                    }
                }
            }
        }
        private void continueBtn_Click(object sender, EventArgs e)
        {
            if(selectedSeats.Count > 0)
            {
                TeatrUIEventHandler.SetSideContent(new TicketSideForm(production, selectedSeats, productionDate, scene));
                TeatrUIEventHandler.ClearMainContent();
            }
        }

        private void scenePanel_Paint_1(object sender, PaintEventArgs e)
        {
            Pen teatrGreenPen = new Pen(Color.FromArgb(107, 216, 180), 2);
            Graphics g = scenePanel.CreateGraphics();
            g.DrawArc(teatrGreenPen, 0, 0, scenePanel.Width, scenePanel.Height + 30, 0, -180);
        }
    }
}
