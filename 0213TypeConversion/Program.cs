using System;

namespace _0213TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("What's your age?");
            // string ageText = Console.ReadLine();
            // // ageText += 10;
            // // System.Console.WriteLine($"You will be { ageText } in 10 years.");
            
            // // Trust convertion
            // // int age = int.Parse(ageText);

            // // Untrust convertion
            // bool isValidAge = int.TryParse(ageText, out int age);
            // if (isValidAge)
            // {
            //     age += 10;
            //     Console.WriteLine($"You will be { age } in 10 years.");
            // }else
            // {
            //     System.Console.WriteLine("That was not a valid age.");
            // }
            
            // Homework: Capture a user's age from the Console and then ideentity how old they were in the year 2000. If they were not born yet, tell them that instead.
            Console.Write("What's your age?");
            string ageText = Console.ReadLine();
            bool isValidAge = int.TryParse(ageText, out int age);
            if (isValidAge)
            {
                int ageIn2000 = age - 21;
                if ( ageIn2000 > 0 )
                {
                    Console.WriteLine($"You are { ageIn2000 } in 2000 years.");
                }else
                {
                    Console.WriteLine("You didn't born in 2000 years.");
                }
            }else
            {
                Console.WriteLine("The age input is not valid.");
            }



            Console.ReadLine();
        }
        
    }
}
