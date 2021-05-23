using System;

namespace _0211BasicVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            
            Console.Write("What is your first name: ");
            firstName = Console.ReadLine();
            
            // if ( firstName.ToLower() == "long")
            // {
            //     Console.WriteLine("Welcome Mr. Yi");
            // }
            
            if ( firstName.ToLower() == "long")
            {
                Console.WriteLine("Hello, Mr. Yi");
            }else{
                Console.WriteLine("Hello other person.");
            }

            Console.WriteLine("Application Done.");

            Console.ReadLine();
        }
    }
}
