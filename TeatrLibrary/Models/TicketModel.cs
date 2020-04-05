using System;
using System.Collections.Generic;
using System.Text;

namespace TeatrLibrary.Models
{
    public class TicketModel 
    { 
        public string PlayName { set; get; }
        public string Scene { set; get; }
        public string Seat { set; get; }
        public decimal Price { set; get; }
        public string ContactName { set; get; }
        public string ContactPhone { set; get; }

    }
}
