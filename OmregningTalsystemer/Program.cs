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
            bool running = true;
            do
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
                    case ConsoleKey.Escape:
                        running = false;
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (running);
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
            Console.ReadKey(true);
        }

        public static void Decimal()
        {
            Console.Clear();
            Console.WriteLine(Text.Insert("decimal"));
            long input = Convert.ToInt64(GetInput(Validation.Dec));
            Console.Clear();
            Text.Results(input, Dec.Bin, Dec.Hex);
            Console.ReadKey();
        }

        public static void Hexadecimal()
        {
            Console.Clear();
            Console.WriteLine(Text.Insert("hexadecimal"));
            string input = GetInput(Validation.Hex);
            Console.Clear();
            Text.Results(input, Hex.Bin, Hex.Dec);
            Console.ReadKey(true);
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
