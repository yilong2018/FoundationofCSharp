using System;

namespace M04L03Instantiated
{
    public class ProcessPerson
    {
        public static void GreetPerson(PersonModel person){
           System.Console.WriteLine($"Hello {person.FirstName} {person.LastName}"); 
           person.HasBeenGreeted = true;
        }
    }
}