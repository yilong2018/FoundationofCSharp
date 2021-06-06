﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M0606AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            Console.ReadLine();
        }
    }

    public abstract class Vehicle
    {
        public string VIN { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
    }

    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; } = 4;
    }

    //Homework: Create an Abstract Class that has an Interface applied to it.
    // When instantiating the child class, store it using the interface type.
}
