using System;
using CalculatorLibrary;
using StandardLibrary;

namespace M07L03ClassLibraryUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Generators generators = new Generators();

            PersonModel person = new PersonModel { Prefix="Mr.", FirstName="Long", LastName="Yi" };

            string message = generators.FarewellMessage(person.Prefix, person.LastName);


            Console.WriteLine(message);

            double d1 = "Please Enter 1st Double: ".StrToDouble();
            double d2 = "Please Enter 2nd Double: ".StrToDouble();

            Calculator.Add(d1, d2).PrintResult();
            Calculator.Sub(d1, d2).PrintResult();
            Calculator.Multiply(d1, d2).PrintResult();
            Calculator.Divide(d1, d2).PrintResult();


            Console.ReadLine();
        }
    }

    // Homework: Build a .NET Standard class library and a Console application. Put a couple calculaiton methods in it and call it from the Console.
}
