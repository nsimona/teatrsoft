using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TeatrLibrary.Models
{
    class DataProtection
    {
        public DataProtection(string s)
        {
            Data = Encoding.ASCII.GetBytes(s);
        }
        public byte[] Data { get; set; }
        byte[] salt1 = new byte[8];
    }
}
