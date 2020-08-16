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
                    "H: Hexadecimal -> Decimal & Binær\n\n" +
                    "ESC: Luk programmet";
        }

        public static string Insert(string numType)
        {
            return $"Indtast et {numType} tal:";
        }

        // Binary
        public static void Results(string input, Func<string, long> dec, Func<string, string> hex)
        {
            Console.WriteLine(DisplayResult("Decimal",(input).ToString(), input));
            Console.WriteLine(DisplayResult("Hexadecimal", hex(input), input));
        }

        // Dec
        public static void Results(long input, Func<long, string> bin, Func<long, string> hex)
        {
            Console.WriteLine(DisplayResult("Binær", bin(input), input.ToString()));
            Console.WriteLine(DisplayResult("Hexadecimal", hex(input), input.ToString()));
        }

        // Hex
        public static void Results(string input, Func<string, string> bin, Func<string, long> dec)
        {
            Console.WriteLine(DisplayResult("Decimal", dec(input).ToString(), input));
            Console.WriteLine(DisplayResult("Binær", bin(input), input));
        }

        private static string DisplayResult(string type, string results, string input)
        {
            ResultString r;
            r.Type = type;
            r.Result = results;
            r.Input = input;

            return $"{r.Type}: {r.Input} -> {r.Result}";
        }

        public struct ResultString
        {
            public string Type;
            public string Result;
            public string Input;

        }
    }
}
