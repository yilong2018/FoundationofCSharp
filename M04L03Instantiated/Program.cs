using System;
using System.Collections.Generic;

namespace M04L03Instantiated
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<PersonModel> people = new List<PersonModel>();
            // PersonModel person = new PersonModel();
            // person.firstName = "Tom";
            // people.Add(person);
            // person = new PersonModel();
            // person.firstName = "Sue";
            // people.Add(person);

            // foreach (PersonModel p in people)
            // {
            //     System.Console.WriteLine(p.firstName);
            // }

            List<PersonModel> people = new List<PersonModel>();
            string firstName = "";
            string lastName = "";
            do{
                System.Console.Write("What is your first name (or type exit to stop: ");
                firstName = Console.ReadLine();
                System.Console.Write("What is your last name: ");
                lastName = Console.ReadLine();
                if ( firstName.ToLower() != "exit")
                {
                    PersonModel person = new PersonModel();
                    person.FirstName = firstName;
                    person.LastName = lastName;
                    people.Add(person);
                }
            }while(firstName.ToLower() != "exit");

            foreach (PersonModel p in people)
            {
                ProcessPerson.GreetPerson(p);
            }

            Console.ReadLine();
        }
    }
}
