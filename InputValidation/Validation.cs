using System;
using System.Text.RegularExpressions;

namespace InputValidation
{
    public class Validation
    {
        public static bool Bin(string input)
        {
            return Regex.IsMatch(input, "^[01]+$");
        }
        public static bool Dec(string input)
        {
            return Regex.IsMatch(input, "^[0123456789]+$");
        }
        public static bool Hex(string input)
        {
            return Regex.IsMatch(input.ToUpper(), "^[0123456789ABCDEF]+$");
        }
    }
}
