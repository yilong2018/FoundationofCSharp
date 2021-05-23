using System;
using System.Collections.Generic;

namespace Module02Lesson10ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] firstNames = new string[] { "Sue", "Bob", "Tim" };
            // for (int i = 0; i < firstNames.Length; i++)
            // {
            //     Console.WriteLine(firstNames[i]);
            // }
            
            // List<string> lastNames = new List<string>(){ "Corey", "Smith", "Jones" };
            // for (int i = 0; i < lastNames.Count; i++)
            // {
            //     Console.WriteLine(lastNames[i]);
            // }

            // Homework
            // Ask the user for a comma-separated list of fisrt names(no spaces).
            // Split the string into a string array. Loop through the array and tell each person hello.

            Console.WriteLine("Input names with ',' separated(no spaces). eg. Bob,John...");
            Console.Write("Input: ");
            string inputNames = Console.ReadLine();
            string[] arrayNames = inputNames.Split(',');
            for (int i = 0; i < arrayNames.Length; i++)
            {
                System.Console.WriteLine($"Hello, {arrayNames[i] }.");
            }

            Console.ReadLine();
        }
    }
}
