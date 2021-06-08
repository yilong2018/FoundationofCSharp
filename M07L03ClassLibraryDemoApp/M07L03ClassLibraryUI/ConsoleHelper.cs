using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M07L03ClassLibraryUI
{
    public static class ConsoleHelper
    {
        public static double StrToDouble(this string message)
        {
            
            double output = 0;
            bool isValidDouble = false;
            while ( isValidDouble == false )
            {               
                Console.Write(message);
                string str = Console.ReadLine();
                isValidDouble = double.TryParse(str, out output);
            }
            return output;
        }

        public static void PrintResult(this double num)
        {
            Console.WriteLine($"The result is :{ num }");
        }

        public static void ReadDouble()
        {

        }
    }
}
