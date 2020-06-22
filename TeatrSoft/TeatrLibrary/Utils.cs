using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TeatrLibrary.Structs;

namespace TeatrLibrary
{
    public class Utils
    {
        public static char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public static string NormalizeSeat(int row, int column)
        {
            return $"{alphabet[row]}{column + 1} ";
        }
        public static int[] DenormalizeSeat(string seat)
        {
            int[] seatArray = new int[2];
            if (seat != "")
            {
                seatArray[0]= Array.IndexOf(alphabet, seat[0]);
                seatArray[1] = Int32.Parse(seat.Remove(0,1)) - 1;
            }
            return seatArray;
        }
        public static List<Seat> DenormalizeSeats(string seats)
        {
            List<Seat> denormalizedSeats = new List<Seat>();
            if (seats != null)
            {
                string[] allSeats = seats.Split(' ');
                foreach(var s in allSeats)
                {
                    int row = DenormalizeSeat(s)[0];
                    int column = DenormalizeSeat(s)[1];
                    denormalizedSeats.Add(new Seat(row, column));
                }
            }
            return denormalizedSeats;
        }
    }
}
