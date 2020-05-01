using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatrLibrary;
using TeatrLibrary.Models;

namespace TeatrUI
{
    public partial class Export : Form
    {
        List<ProductionModel> productions = GlobalConfig.Connection.GetProductionsList();
        public Export()
        {
            InitializeComponent();
        }
        
        private void resetControls()
        {
            productionComboBox.SelectedIndex = 0;
            DateTime date = DateTime.Now;
            DateTime firstDayOfMonth = new DateTime(date.Year, date.Month, 1);
            fromDateControl.Value = firstDayOfMonth;
            toDateControl.Value = firstDayOfMonth.AddMonths(1).AddDays(-1);
            infoLabel.Text = "";
        }

        private void Export_Load(object sender, EventArgs e)
        {
            ProductionModel defaultP = new ProductionModel();
            defaultP.Name = "Всички постановки";
            defaultP.Id = 0;
            productions.Insert(0, defaultP);
            productionComboBox.DataSource = productions;
            productionComboBox.DisplayMember = "Name";
            productionComboBox.ValueMember = "Id";
            resetControls();
        }

        private void generatebtn_Click(object sender, EventArgs e)
        {
            string file = GlobalConfig.Connection.GetTotal(fromDateControl.Value, toDateControl.Value, (int)productionComboBox.SelectedValue);
            infoLabel.Text = $"Отчет за периода " +
                $"{fromDateControl.Value:dd.MM.yy} - {toDateControl.Value:dd.MM.yy} \n" +
                $"за постановка: {productionComboBox.Text} \n" +
                $"е записан в папка Exports на нивото на проекта като csv файл с името " +
                $"{file} :)";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            resetControls();
        }
    }
}
