using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M06L07MethodOverridingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel { 
                    FirstName = "Tim",
                    LastName = "Corey",
                    Email = "tim@iamtimcorey.com"
            };

            Console.WriteLine(person.ToString());

            Console.ReadLine();
        }
    }

    public class Hperson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Hemployee: Hperson
    {
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
