using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatrLibrary.Models
{
    public class Position
    {
        public int Id {get; set;}
        public string Name { get; set; }

        public Position(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
