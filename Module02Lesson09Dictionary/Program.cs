using System;
using System.Collections.Generic;

namespace Module02Lesson09Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> importantYears = new Dictionary<int, string>();
            
            importantYears[1492] = "Columbus dicovered the new world.";
            importantYears[1969] = "Man walks on the moon.";
            importantYears[1982] = "Yi is born.";

            System.Console.WriteLine($"In the year 1982, this happend: { importantYears[1969] } ");

            // Homework
            // Create a Dictionary list of employee IDs and the name that goes with that ID. Fill it with a few records. Then ask the user for their ID and return their name.
            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees[2001] = "Bob";
            employees[2002] = "Sue";
            employees[2003] = "David";

            Console.Write("What is your ID? ");
            string idText = Console.ReadLine();
            bool isValidID = int.TryParse(idText, out int id);
            if ( isValidID == true && id > 2000 && id < 2004 )
            {
                Console.Write($"The ID you input is {id}, and the name correspond with the id is { employees[id] } ");
            }else
            {
                System.Console.WriteLine($"We can't find the {id} in our company.");
            }

            Console.ReadLine();
        }
    }
}
