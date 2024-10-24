using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Menu
    {

        public static void PrintMenu(string message)
        {
            Console.WriteLine(message);
            Console.Write("=>");
        }
        

        public static int GetInputParsedInt()
        {
            String input = Console.ReadLine()?.Trim();

            if (int.TryParse(input, out int option)) return int.Parse(input);
            else return 0;

        }

        public static string GetInputString()
        {
            return Console.ReadLine()?.Trim();
        }
    }
}
