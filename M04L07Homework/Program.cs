using System;
using System.Collections.Generic;
using M04L07HomeworkLibrary.Models;

namespace M04L07Homework
{
    class Program
    {
        public static List<Guest> guests = new List<Guest>();
        static void Main(string[] args)
        {
            // Recreate the guest book project with out looking back.
            // Just take the concept and create the application.

            GetGuestsInformation();

            PrintGuestsInformation();

            Console.ReadLine();
        }
        public static void GetGuestsInformation()
        {
            string moreGuestsComing = "";
            do
            {
                Guest guest = new Guest();

                guest.FirstName = GetStringFromConsole("What's your first name: ");
                guest.LastName = GetStringFromConsole("What's your last name: ");
                guest.Age = GetIntFromConsole("What's your age: ");
                guest.MessageToHost = GetStringFromConsole("What do you want to say to host: ");
                guests.Add(guest);

                moreGuestsComing = GetStringFromConsole("Are there any guests (yes/no): ");
                Console.Clear();

            } while (moreGuestsComing == "yes");
        }
        public static void PrintGuestsInformation()
        {
            foreach (Guest guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }
        public static string GetStringFromConsole(string message)
        {
            string output = "";
            Console.Write(message);
            output = Console.ReadLine();
            return output;
        }
        public static int GetIntFromConsole(string message)
        {
            string intInputText = "";
            bool isValidInt = false;
            int intInput = 0;
            while (isValidInt == false)
            {
                intInputText = GetStringFromConsole(message);
                isValidInt = int.TryParse(intInputText, out intInput);
            }
            return intInput;

        }
    }
}
