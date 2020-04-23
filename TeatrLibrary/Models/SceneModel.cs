using System;
using System.Collections.Generic;
using System.Text;

namespace TeatrLibrary.Models
{
    public class SceneModel
    {
        public SceneModel() {}
        public SceneModel(int id, string name, string address, decimal price, int seats, int rows, int cols)
        {
            Id = id;
            Name = name;
            Address = address;
            TicketPrice = price;
            SeatsCount = seats;
            Rows = rows;
            Cols = cols;
        }

        public int Id{ get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal TicketPrice { get; set; }
        public int SeatsCount { get; set; }
        public string Schema { get; set; }
        public int Rows { get; set; }
        public int Cols { get; set; }
        public int[,] Model { get; set; }

        public void SetModel()
        {
            int[,] model = new int[Rows, Cols];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    char s = Schema[(i*Cols) + j];
                    model[i, j] = (int)char.GetNumericValue(s);
                }
            }
            this.Model = model;
        }
    }
}
