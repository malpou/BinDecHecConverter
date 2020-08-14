using System;
using System.Linq;

namespace NumberConversion
{
    public class Hex
    {
        public static long Dec(string hex)
        {
            return long.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        }

        public static string Bin(string hex)
        {
            return String.Join(String.Empty,
                hex.Select(
                    c => Convert.ToString(Convert.ToInt64(c.ToString(), 16), 2).PadLeft(4, '0'))
                );
        }
    }
}
