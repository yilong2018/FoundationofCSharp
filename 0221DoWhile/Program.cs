using System;

namespace _0221DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // //Do loop
            // string isContinue = "";
            // do
            // {
            //     System.Console.Write("What's yoru name? ");
            //     string userName = Console.ReadLine();
            //     Console.WriteLine($"Hello, welcome { userName }");

            //     Console.Write("Do you want to continue?(yes/no) ");
            //     isContinue = Console.ReadLine();
            // } while ( isContinue.ToLower() == "yes" );

            // // While loop
            // Console.Write("What is your age? ");
            // string ageText = Console.ReadLine();
            // bool isValidAge = int.TryParse(ageText, out int age);

            // while ( isValidAge == false )
            // {
            //     Console.WriteLine("The age you input isn't a number, please try again.");
            //     Console.Write("What's your age? ");
            //     ageText = Console.ReadLine();
            //     isValidAge = int.TryParse(ageText, out age);
            // }

            // Console.WriteLine($"Your age in 10 years will be { age + 10 }.");


            // Homework
            // Do loop
            // string isExit = "";
            // do
            // {
            //     Console.Write("What is your name? ");
            //     string userName = Console.ReadLine();
            //     if ( userName.ToLower() == "tim" )
            //     {
            //         Console.WriteLine("Hello Professor.");
            //     }else
            //     {
            //         Console.WriteLine($"Hi { userName }");
            //     }
            //     Console.Write("Do you want to exit? (exit/not)");
            //     isExit = Console.ReadLine();
            // } while ( isExit.ToLower() != "exit" );

            // While loop
            string isExit = "";
            while (isExit.ToLower() != "exit")
            {
                Console.Write("What is your name? ");
                string userName = Console.ReadLine();
                if (userName.ToLower() == "tim")
                {
                    Console.WriteLine("Hello Professor.");
                }
                else
                {
                    Console.WriteLine($"Hi { userName }");
                }
                Console.Write("Do you want to exit? (exit/no)");
                isExit = Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
