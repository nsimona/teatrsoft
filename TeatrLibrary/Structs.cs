using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatrLibrary
{
    public class Structs
    {
        public struct Seat
        {
            public Seat(int row, int column)
            {
                Row = row;
                Column = column;
            }

            public int Row { get; }
            public int Column { get; }

            public override string ToString() => Utils.NormalizeSeat(Row, Column);
        }
    }
}
