using System;
using System.Collections.Generic;

namespace M0602Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Phone> phones = new List<Phone>();
            phones.Add(new Cellphone());
            phones.Add(new Smartphone());

            foreach (var phone in phones)
            {
                if (phone is Cellphone cell)
                {
                    cell.Carrier = "";
                }
                if (phone is Smartphone smartphone)
                {
                    smartphone.ConnectToInternet();
                }
            }
            Console.ReadLine();
        }
    }


    // Don't inherit from the car, because Tundra is a trunk.
    // A trunk is not a car.
    public class Tundra : Car
    {

    }
    public class Cellphone : Phone
    {
        public string Carrier { get; set; }
    }
    public class Smartphone : Cellphone
    {
        public List<string> Apps { get; set; }
        public void ConnectToInternet()
        {

        }

    }
    public class LandLine : Phone
    {

    }
    // Don't inhertient from and class
    // If it don't 
    public class Hotspot
    {

    }
    public class Phone
    {
        public void PlaceCall() { }
        public void EndCall() { }
    }
    public class WalkieTalkie
    {

    }
}
