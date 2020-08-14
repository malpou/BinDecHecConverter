using System;
using System.Collections.Generic;
using System.Text;

namespace NumberConversion
{
    public class Bin
    {
        public static long Dec(string bin)
        {
            return Convert.ToInt64(bin, 2);
        }

        public static string Hex(string bin)
        {
            return Convert.ToInt64(bin, 2).ToString("X");
        }
    }
}
