using System;
using System.Collections.Generic;

namespace Module02Lesson13MiniP
{
    class Program
    {
        private static List<string> partyNames = new List<string>();
        private static int totalGuests = 0;
        static void Main(string[] args)
        {
            //Build a Console Guest Book. Ask the user for their name and how many are in their party.
            //Keep track of how many people are at the party. At the end, print out the guest list and the total number of guests.

            //1stTime did homework
            // Dictionary<string, int> guests = new Dictionary<string, int>();
            // guests = GetGuests();
            // PrintGuests(guests);

            //2ndTime did homework
            //Ask for the user's name
            //Add the name to the list of names
            //Ask for the user's party count
            //Add the party count to the total party number
            //print out all names
            //print out total party number

            LoadGuests();

            DisplayGuests();
            
            DisplayTotalGuests();

            Console.ReadLine();

        }
        private static void DisplayTotalGuests(){
            Console.WriteLine();
            Console.WriteLine($"Total Guests: {totalGuests}");
        }
        private static void DisplayGuests(){
            Console.WriteLine();
            Console.WriteLine("Party Names: ");
            foreach (var party in partyNames)
            {
                Console.WriteLine(party);
            }
        }
        private static void LoadGuests()
        {
            string moreGuests = "";
            do
            {
                string partyName = GetInforFromConsole("What's your party name: ");
                partyNames.Add(partyName);
                int guestNumber = GetGuestsNumber("How many people are you: ");
                totalGuests += guestNumber;
                DisplayTotalGuests();
                moreGuests = GetInforFromConsole("Are there more guests(yes/no): ");
            } while (moreGuests == "yes");
        }
        private static int GetGuestsNumber(string message)
        {
            bool isValidNumber = false;
            int guestNumber = 0;

            while (isValidNumber == false)
            {
                string guestNumberText = GetInforFromConsole(message);
                isValidNumber = int.TryParse(guestNumberText, out guestNumber);
            }

            return guestNumber;
        }
        private static string GetInforFromConsole(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();
            return output;
        }

        //2ndTime did homeowrk

        //1stTime did homework
        // private static Dictionary<string, int> GetGuests(){
        //     string exit = "";
        //     Dictionary<string, int> guests = new Dictionary<string, int>();
        //     while ( exit != "no" )
        //     {
        //         Console.Write("What is your name? ");
        //         string name = Console.ReadLine();
        //         Console.Write("How man people with you? ");
        //         string numberText = Console.ReadLine();
        //         bool isValidNumber = int.TryParse(numberText, out int number);              
        //         guests.Add(name, number);
        //         Console.Write("Is there any guests? (yes/no): ");
        //         exit = Console.ReadLine();
        //     }
        //     return guests;
        // }
        // private static void PrintGuests(Dictionary<string, int> guests){
        //     int totalGuestNumber = 0;
        //     foreach (var guest in guests)
        //     {
        //         Console.WriteLine($"{ guest.Key } partied. ");
        //         totalGuestNumber += guest.Value;
        //     }
        //     Console.WriteLine($"There are {totalGuestNumber} guests in the party.");
        // }
    }
}
