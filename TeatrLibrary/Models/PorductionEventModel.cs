using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatrLibrary.Models
{
    public class PorductionEventModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public  string Scene { get; set; }

        public string FullEventDescription
        {
            get {
                return $"{Date.ToShortDateString()}\t\t{Time.ToShortTimeString()}\t\t{Scene}";  
                //return string.Format("{0,-15}  {1,-15}  {2, -30}", Date.ToShortDateString(), Time.ToShortTimeString(), Scene);
            }
        }
    }
}
