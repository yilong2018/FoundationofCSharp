using System;
using M04L06AddedLibrary.Models;

namespace M04L06ClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
            person.FirstName = "Long";
            person.LastName = "Yi";

            Console.WriteLine(person.FullName);
            Console.ReadLine();
        }
        //Homework
        // Create a class library that holds a Person class. Use that
        // class in a console application.
        
    }
}
