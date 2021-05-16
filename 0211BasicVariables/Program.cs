using System;

namespace _0211BasicVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            string fullName = "";

            firstName = "Tim";
            lastName = "Corey";
            // $ is for string interpolation
            fullName = $"{ firstName } { lastName }";
            
            
            string fileName ="";
            // @ is for string literals
            fileName = @"C:\Temp|temp.txt";

            // Whole number
            int age = 0;
            age = 25;

            string zipCode = "00411-4125";
            System.Console.WriteLine(zipCode.ToString());
            
            // Use double for all numbers that include fractions except for money
            double averageWordsPerMinute = 34.24;
            // Use decimal for money
            decimal costPerContainer = 43.85M;

            // Stores only true or false
            bool isAlive = false;


            System.Console.WriteLine(age);
            Console.ReadLine();
        }
    }
}
