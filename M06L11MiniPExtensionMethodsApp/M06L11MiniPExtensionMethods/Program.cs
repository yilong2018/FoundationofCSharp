using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M06L11MiniPExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();

            person.FirstName = "What is your first name: ".RequestString();

            person.LastName = "What is your last name: ".RequestString();

            person.Age = "What is your age: ".RequestInt(0, 120);
            // person.Age = ConsoleHelper.RequestInt("What is your age", 0, 120);

            Console.WriteLine($"{person.FirstName} {person.LastName}'s age is: {person.Age}");

            Console.ReadLine();
        }

        // Recreate the project we did for this lesson but without looking back over what I did. Tweak it slightly as well.
        // How much money they have in their bank account.
        // What was the last thing you bought and how much money was it? decimal
        // double, boolean
    }
}
