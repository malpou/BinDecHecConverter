using System;
using System.Collections.Generic;
using System.Text;

namespace NumberConversion
{
    public class Dec
    {
        public static string Bin(long dec)
        {
            return Convert.ToString(dec, 2);
        }

        public static string Hex(long dec)
        {
            return dec.ToString("X");
        }
    }
}
