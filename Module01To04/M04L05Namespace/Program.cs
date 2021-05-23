using System;
using System.Collections.Generic;
using FoundationInfo.Calculator.PersonalCalculators.YiCalculators;
using M04L05Namespace.Models;
using Calculate;

namespace M04L05Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>();
            Console.WriteLine();

            PersonModel person = new PersonModel();
            Calculations.Add(1.11, 2.22);

            // Create a class file and change the namespace 
            // to be something different. Call a method in that class.
            Console.WriteLine($"11.11 + 22.22 = {calculator.Add(11.11,22.22)}");
            Console.ReadLine();
        }
    }
}
