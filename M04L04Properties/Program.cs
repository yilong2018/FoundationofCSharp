using System;

namespace M04L04Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel( "Long" );
            person.FirstName = "Yi";
            person.Age = 40;
            person.SSN = "123-45-6789";

            Console.WriteLine(person.SSN);
            System.Console.WriteLine(person.FullName);

            //Homework
            //Create a class that has properties for street address, city, state, and zip code.
            //Then add a FullAddress property that is read-only.
            AddressModel address = new AddressModel();
            address.StreetAddress = "BaoJiaXiang";
            address.City = "Chengdu";
            address.State = "Sichuan";
            address.ZipCode = "610000";
            Console.WriteLine(address.FullAddress);
            
            Console.ReadLine();
        }
    }
}
