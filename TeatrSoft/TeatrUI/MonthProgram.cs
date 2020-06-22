using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using TeatrLibrary;
using TeatrLibrary.Models;
using TeatrUI.UserControls;

public struct Month
{
    public Month(int intValue, string strValue)
    {
        i = intValue;
        month = strValue;
    }

    public int i { get; private set; }
    public string month { get; private set; }
}

namespace TeatrUI
{
    public partial class MonthProgram : Form
    {
        private List<DateTime> availableMonths = GlobalConfig.Connection.GetAllEventDates();
        //private List<ProductionEventModel> program;
        public MonthProgram()
        {
            InitializeComponent();
        }

        private void MonthProgram_Load(object sender, EventArgs e)
        {
            List<Month> months = availableMonths
                .Select(date => new Month(date.Month, $"{Utils.MapMonth(date.Month)} {date.Year}"))
                .Distinct()
                .ToList();
            monthComboBox.DataSource = months;
            monthComboBox.DisplayMember = "month";
            monthComboBox.ValueMember = "i";
            monthComboBox.SelectedValue = DateTime.Now.Month;
            GetProgram();
        }

        private void GetProgram()
        {
            List<ProductionEventModel> program = GlobalConfig.Connection.GetAllDatesForMonth((int)monthComboBox.SelectedValue);
            PrintProgram(program);
        }

        private void PrintProgram(List<ProductionEventModel> p)
        {

            programPanel.Controls.Clear();
            var groupByDate = p.GroupBy(production => production.Date)
                .Select(group => new { Date = group.Key, Productions = group.ToList()})
                .ToList();

            foreach (var d in groupByDate)
            {
                ProgramDateControl date = new ProgramDateControl();
                date.Date = d.Date.ToString("dd.MM.yyyy");
                date.Day = Utils.MapDay((int)d.Date.DayOfWeek);
                programPanel.Controls.Add(date);
                var groupByScene = d.Productions.GroupBy(production => production.SceneName)
                    .Select(group => new { Name = group.Key, Productions = group.ToList() })
                    .ToList();
                foreach (var scene in groupByScene)
                {
                    Label sceneLabel = new Label();
                    sceneLabel.Text = scene.Name;
                    sceneLabel.AutoSize = true;
                    sceneLabel.Padding = new Padding(40, 0, 0, 5);
                    sceneLabel.Font = new Font("Montserrat", 12, FontStyle.Bold);
                    sceneLabel.ForeColor = Color.FromArgb(253, 101, 101);
                    programPanel.Controls.Add(sceneLabel);
                    foreach (ProductionEventModel prod in scene.Productions)
                    {
                        Label production = new Label();
                        production.Text = $"{prod.Time:hh\\:mm} {prod.ProductionName}";
                        production.AutoSize = true;
                        production.Padding = new Padding(50, 0, 0, 5);
                        production.Font = new Font("Montserrat", 12, FontStyle.Regular);
                        production.ForeColor = Color.FromArgb(100, 100, 100);
                        programPanel.Controls.Add(production);
                    }
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            GetProgram();
        }
    }
}
