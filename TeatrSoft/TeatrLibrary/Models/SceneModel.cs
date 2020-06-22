using System;
using System.Collections.Generic;
using System.Text;

namespace TeatrLibrary.Models
{
    public class SceneModel
    {
        public SceneModel() {}

        public int Id{ get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public int SeatsCount { get; set; }
        public string Address { get; set; }
        public decimal Price { get; set; }
        public int Rows { get; set; }
        public int Cols { get; set; }
        public int[,] Schema { 
            get {
                int[,] model = new int[Rows, Cols];
                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Cols; j++)
                    {
                        char s = Model[(i * Cols) + j];
                        model[i, j] = (int)char.GetNumericValue(s);
                    }
                }
                return model;
            }
        }
/*      TODO - chek improvements methods
        public void SetModel()
        {
            int[,] model = new int[Rows, Cols];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    char s = Model[(i*Cols) + j];
                    model[i, j] = (int)char.GetNumericValue(s);
                }
            }
            this.Schema = model;
        }*/
    }
}
