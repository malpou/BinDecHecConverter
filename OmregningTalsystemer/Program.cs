using System;
using NumberConversion;
using InputValidation;
using Display;

namespace OmregningTalsystemer
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                while (!Console.KeyAvailable)
                {
                    Console.CursorVisible = false;
                    Console.WriteLine(Text.Meny());
                    ConsoleKeyInfo inputKey = Console.ReadKey(true);
                    switch (inputKey.Key)
                    {
                        case ConsoleKey.B:
                            MenyPoints.Binary();
                            break;
                        case ConsoleKey.D:
                            MenyPoints.Decimal();
                            break;
                        case ConsoleKey.H:
                            MenyPoints.Hexadecimal();
                            break;
                        default:
                            break;
                    }
                    Console.ReadKey(true);
                    Console.Clear();
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }

    class MenyPoints
    {
        public static void Binary()
        {
            Console.Clear();
            Console.WriteLine(Text.Insert("binært"));
            string input = GetInput(Validation.Bin);
            Console.Clear();
            Text.Results(input, Bin.Dec, Bin.Hex);
        }

        public static void Decimal()
        {
            Console.Clear();
            Console.WriteLine(Text.Insert("decimal"));
            long input = Convert.ToInt64(GetInput(Validation.Dec));
            Console.Clear();
            Text.Results(input, Dec.Bin, Dec.Hex);
        }

        public static void Hexadecimal()
        {
            Console.Clear();
            Console.WriteLine(Text.Insert("hexadecimal"));
            string input = GetInput(Validation.Hex);
            Console.Clear();
            Text.Results(input, Hex.Bin, Hex.Dec);
        }

        private static string GetInput(Func<string, bool> validate)
        {
            string input;
            do
            {
               input = Console.ReadLine();
            } while (!validate(input));
            return input;
        }
    }
}
