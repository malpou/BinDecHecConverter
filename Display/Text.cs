using System;

namespace Display
{
    public class Text
    {
        public static string Meny()
        {
            return "Velkommen til nummer omregneren\n\n" +
                    "Klik på en tast for at gå til omregneren:\n" +
                    "B: Binær -> Decimal & Hexadecimal\n" +
                    "D: Decimal -> Binær & Hexadecimal\n" +
                    "H: Hexadecimal -> Decimal & Binær";
        }

        public static string Insert(string numType)
        {
            return $"Indtast et {numType} tal:";
        }

        // Binary
        public static void Results(string input, Func<string, long> dec, Func<string,string> hex)
        {
            Console.WriteLine(DecResult(dec(input).ToString(),input));
            Console.WriteLine(HexResult(hex(input),input));
        }

        // Dec
        public static void Results(long input, Func<long, string> bin, Func<long,string> hex)
        {
            Console.WriteLine(BinResult(bin(input),input.ToString()));
            Console.WriteLine(HexResult(hex(input),input.ToString()));
        }

        // Hex
        public static void Results(string input, Func<string, string> bin, Func<string, long> dec)
        {
            Console.WriteLine(DecResult(dec(input).ToString(), input));
            Console.WriteLine(BinResult(bin(input), input));
        }

        private static string BinResult(string result, string input)
        {
            return $"Binær: {input} -> {result}";
        }

        private static string DecResult(string result, string input)
        {
            return $"Decimal: {input} -> {result}";
        }

        private static string HexResult(string result, string input)
        {
            return $"Hexadecimal: {input} -> {result}";
        }

    }
}
