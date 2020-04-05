using System;
using System.Collections.Generic;
using System.Text;

namespace TeatrLibrary.Models
{
    public class SceneModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal TicketPrice { get; set; }
        public short SeatsCount { get; set; }
        public int[][] Schema { get; set; }
        public DateTime[] DatesBusy { get; set; }

        public void draw() { }
        public void setColor() { }
        public void setSeatAvailable() { }
        public bool isSceneAvailable(DateTime start, short duration) {
            return false;
        }
        public void resrve(DateTime start, short duration)
        {
            if (isSceneAvailable(start, duration))
            {

            }
        }
    }
}
