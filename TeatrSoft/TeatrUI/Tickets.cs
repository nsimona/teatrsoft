using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatrLibrary.Models;
using TeatrUI.UserControls;
using static TeatrLibrary.Structs;

namespace TeatrUI
{
    public partial class Tickets : Form
    {
        public Tickets(ProductionModel production, List<Seat> seats, ProductionEventModel productionDate, SceneModel scene)
        {
            InitializeComponent();
            foreach(Seat s in seats)
            {
                TicketControl ticket = new TicketControl();
                ticket.produtctionTitleField.Text = production.Name;
                ticket.sceneField.Text = scene.Name;
                ticket.sceneAddressField.Text = scene.Address;
                ticket.rowField.Text = $"{s.ToString()[0]}";
                ticket.seatField.Text = $"{s.Column + 1}";
                ticket.dateField.Text = $"{Utils.MapDay((int)productionDate.Date.DayOfWeek)}, " +
                    $"{productionDate.Date:dd.MM.yy}" +
                    $"\n{productionDate.Time:hh\\:mm}";
                ticket.priceField.Text = $"{scene.Price:0.00} лв";
                ticketsPanel.Controls.Add(ticket);
            }
        }
        // TODO - print tickets
        private void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(ticketsPanel.Width, ticketsPanel.Height);
            ticketsPanel.DrawToBitmap(bmp, new Rectangle(0, 0, ticketsPanel.Width, ticketsPanel.Height));
            e.Graphics.DrawImage((Image)bmp, x, y);
        }
        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += this.doc_PrintPage;

            PrintDialog dlg = new PrintDialog();
            dlg.Document = doc;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
    }
}
