using System;
using M04L07GuestBookLibrary.Models;
using System.Collections.Generic;

// Capture the information about each guest (assumption is at least one guest and unknown maximum)
// Info to capture: First name, last name, message to the host
// Once done, loop through each guest and print their info


namespace M04L07BetterGuestBook
{
    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();
        static void Main(string[] args)
        {
            GetGuestInformation();

            PrintGuestInformation();

            Console.ReadLine();
        }
        private static void GetGuestInformation()
        {
            string moreGuestsComing = "";
            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetInforFromConsole("What is your first name: ");
                guest.LastName = GetInforFromConsole("What is your last name: ");
                guest.MessageToHost = GetInforFromConsole("What message would you like to tell your Host: ");
                moreGuestsComing = GetInforFromConsole("Are there more guests (yes/no): ");

                guests.Add(guest);

                Console.Clear();
            } while (moreGuestsComing.ToLower() == "yes");
        }
        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                System.Console.WriteLine(guest.GuestInfo);
            }
        }
        private static string GetInforFromConsole(string message)
        {
            string output = "";
            
            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }
    }
}
