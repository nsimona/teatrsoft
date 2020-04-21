using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeatrLibrary.Models;

namespace TeatrUI
{
    public partial class ProductionSideForm : Form
    {
        public ProductionSideForm(ProductionModel production)
        {
            InitializeComponent();
            titleField.Text = production.Name;
            posterField.Image = Utils.LoadImage("production", production.PosterFileName);
            authorField.Text = production.Author;
            directorField.Text = production.DirectorName;
            actorsField.Text = string.Join(", ", production.Actors.Select(x => x.Name));
            durationField.Text = $"{production.Duration} мин";
        }
    }
}
