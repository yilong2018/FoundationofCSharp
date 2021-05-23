using System;

namespace _0212Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Homework
            System.Console.Write("Please Enter your name:");
            var userName = Console.ReadLine();
            if (userName.ToLower() == "tim")
            {
                System.Console.WriteLine($"Welcome professor Tim.");
            }else{
                System.Console.WriteLine($"Welcome student {userName}.");
            }

            Console.ReadLine();
        }
    }
}
