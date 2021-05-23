using System;
using System.Collections.Generic;

namespace Module02Lesson11Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<string> firstNames = new List<string>();

            // firstNames.Add("Tim");
            // firstNames.Add("Sue");
            // firstNames.Add("Bob");
            // firstNames.Add("Dan");

            // foreach (string name in firstNames)
            // {
            //     Console.WriteLine(name);
            // }

            // Dictionary<int, string> importantYears = new Dictionary<int, string>();

            // importantYears.Add(1492, "Columns arrives in Central America.");
            // importantYears.Add(1969, "Man walks on the moon.");
            // importantYears.Add(1982, "Kevin is born.");

            // foreach (var year in importantYears)
            // {
            //     Console.WriteLine($"{year.Key}:{year.Value}");
            // }

            // Homework
            // Ask the user for their first name. Continue asking for first names until
            // there are no more. Then loop through each name using foreach and tell them hello.

            string name = "";
            List<string> userNames = new List<string>();
            while (name.ToLower() != "no")
            {
                Console.Write("What is your name? (type no to quite): ");
                name = Console.ReadLine();
                if (name != "no")
                {
                    userNames.Add(name);

                }
            }

            foreach (var un in userNames)
            {
                Console.WriteLine($"Hello, {un}.");
            }


            Console.ReadLine();
        }
    }
}
