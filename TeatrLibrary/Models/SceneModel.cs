using System;
using System.Collections.Generic;
using System.Text;

namespace TeatrLibrary.Models
{
    public class SceneModel
    {
        public SceneModel(int id, string name, string address, decimal price, int seats)
        {
            Id = id;
            Name = name;
            Address = address;
            TicketPrice = price;
            SeatsCount = seats;
        }

        public int Id{ get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal TicketPrice { get; set; }
        public int SeatsCount { get; set; }
        public int[][] Schema { get; set; }

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
