using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M0605AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            DataAccess dataAccess = new DataAccess();

            Veicle veicle = new Veicle();
            Car car = new Car();
            car.AutoStart();

            Console.ReadLine();
        }
    }

    // Homework: Create a Class Library and a console application. Create a public class with memers that
    // have different modifiers. Try each out.
}
