using System;
using M05L04BattleshipLiteLibrary.Models;

namespace M05L06BattleshipGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerInfoModel playerA = new PlayerInfoModel();
            playerA.UserName = GettingString("What's your name player1: ");



            Console.ReadLine();
        }

        //// [L]ogic design
        // Clear display
        // enum
        // Method: Asking for name
        // Method: Get ship placement
        // Method: Determine if valid spot for ship
        // Storing ship information: List per user?
        // Storing shot information: List per user?
        // Method: create the grid for each user.
        // Method: print out grid.
        // Method: fire on opponent.
        // Method: determine if a shot can be taken & outcome
        // Method: display score
        // Method: print winner and shot taken

        public static void PrintMessage(string message){
            Console.Write(message);
        }
        public static string GettingString(string message)
        {
            string output = "";
            PrintMessage(message)
            output = Console.ReadLine();
            return output;
        }
        public static GridSpotModel GettingShipPlacement(PlayerInfoModel player){
            PrintMessage("{player.UserName} :");
            foreach(var sl in player.shipLocations){
                PrintMessage($"{sl.SpotLetter},");
            }
            Console.ReadLine();
        }
    }
}
