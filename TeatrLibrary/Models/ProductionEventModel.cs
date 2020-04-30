using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TeatrLibrary.Structs;

namespace TeatrLibrary.Models
{
    public class ProductionEventModel
    {
        public ProductionEventModel(){}
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public  int SceneId { get; set; }
        public string SceneName { get; set; }
        public int SoldTickets { get; set; }
        private string ReservedSeats { get; set; }
        public List<Seat> ReservedSeatsList { 
            get {
                return Utils.DenormalizeSeats(this.ReservedSeats);
            } 
        }
        public string FullEventDescription => $"{Date:dd/MM/yyyy}\t{Time}\t\t{SceneName}";
    }
}
