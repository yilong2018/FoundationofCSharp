using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "What is your first name: ".RequestString();
            person.LastName = "What is your last name: ".RequestString();
            //person.Salary = "What is your monthly Salary($): ".RequestDecimal();
            person.Salary = "What is your monthly Salary($): ".RequestDecimal(0, 1000);


            Console.WriteLine($"{ person.FirstName } { person.LastName }'s monthly salary is: ${person.Salary}");

            Console.ReadLine();
        }
    }
    public static class PersonHelper
    {
        public static string RequestString(this string message)
        {
            string output = "";

            while (string.IsNullOrWhiteSpace(output) == true)
            {
                Console.Write(message);
                output = Console.ReadLine();
            }

            return output;
        }
        public static decimal RequestDecimal(this string message)
        {
            return message.RequestDecimal(false);
        }
        public static decimal RequestDecimal(this string message, decimal minValue, decimal maxValue)
        {
            return message.RequestDecimal(true, minValue, maxValue);
        }
        public static decimal RequestDecimal (this string message, bool hasRange, decimal minValue=0, decimal maxValue=0)
        {
            decimal output = 0;
            bool isValidDecimal = false;
            bool isInRange = true;

            while (isValidDecimal == false || isInRange == false)
            {
                string str = message.RequestString();
                isValidDecimal = decimal.TryParse(str, out output);

                if ( hasRange == true )
                {
                    isInRange = (output >= minValue && output <= maxValue);
                    //if (output >= minValue && output <= maxValue)
                    //{
                    //    isInRange = true;
                    //}
                    //else
                    //{
                    //    isInRange = false;
                    //}
                }

            }
            return output;
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
    }
}
