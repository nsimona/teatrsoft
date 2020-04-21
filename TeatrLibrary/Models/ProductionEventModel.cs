using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatrLibrary.Models
{
    public class ProductionEventModel
    {
        public ProductionEventModel(int id, DateTime date, TimeSpan time)
        {
            Id = id;
            Date = date;
            Time = time;
        }
        public ProductionEventModel(){}
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public  int Scene { get; set; }
        public string SceneName { get; set; }
        public string FullEventDescription => $"{Date:dd/MM/yyyy}\t{Time}\t\t{SceneName}";
    }
}
