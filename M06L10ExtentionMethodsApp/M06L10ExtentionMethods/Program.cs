using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M06L10ExtentionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelRoomModel hotelRoom = new HotelRoomModel();
            hotelRoom.TurnOneAir().SetTemperature(72).OpenShades();
            hotelRoom.TurnOffAir().CloseShapes();
            //ExtentionSamples.PrintToConsole("This is a message");
            "Hello world".PrintToConsole();

            Person person = new Person();
            person.SetDefaultAge().PrintInfo();

            Console.ReadLine();
        }
    }
    public class HotelRoomModel
    {
        public int Temperature { get; set; }
        public bool IsAirRunning { get; set; }
        public bool AreShadesOpen { get; set; }
    }
    public static class ExtentionSamples
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
        public static HotelRoomModel TurnOneAir(this HotelRoomModel room)
        {
            room.IsAirRunning = true;
            return room;
        }
        public static HotelRoomModel TurnOffAir(this HotelRoomModel room)
        {
            room.IsAirRunning = false;
            return room;
        }
        public static HotelRoomModel SetTemperature(this HotelRoomModel room, int temperature)
        {
            room.Temperature = temperature;
            return room;
        }
        public static HotelRoomModel OpenShades(this HotelRoomModel room)
        {
            room.AreShadesOpen = true;
            return room;
        }
        public static HotelRoomModel CloseShapes(this HotelRoomModel room)
        {
            room.AreShadesOpen = false;
            return room;
        }
    }
    // Homework: Create the following chain using extension methods: person.SetDefaultAge().PrintInfo();
    public class Person
    {
        public int Age { get; set; }
    }
    public static class PersonExtention{
        public static Person SetDefaultAge(this Person person)
        {
            person.Age = 18;
            return person;
        }
        public static void PrintInfo(this Person person)
        {
            Console.WriteLine($"The person's age is {person.Age}");
        }
    }
}
