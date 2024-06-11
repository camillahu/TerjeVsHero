using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public static class ConsoleUI
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static string RequestString(this string message)
        {
            var output = "";
            while (string.IsNullOrWhiteSpace(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }

        public static int RequestInt(this string message)
        {
            string input;
            int output = 0;
            bool isValidNum = false;

            while (!isValidNum)
            {
                Console.Write(message);
                input = Console.ReadLine();

                isValidNum = int.TryParse(input, out output);
            }

            return output;
        }
    }
}
