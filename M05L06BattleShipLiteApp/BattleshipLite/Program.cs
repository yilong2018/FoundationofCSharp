using BattleShipLiteLibrary;
using BattleShipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLite
{
    class Program
    {
        static void Main(string[] args)
        {
            // SOLID
            // Single responsibility principle
            // quarter back responsibility: controlling the application and calling the place
            WelcomeMessage();

            PlayerInfoModel activePlayer = CreatePlayer("Player 1");
            PlayerInfoModel opponent = CreatePlayer("Player 2");
            PlayerInfoModel winner = null;

            do
            {
                // Display grid from activePlayer on where they fired
                DisplayShotGrid(activePlayer);

                // Ask player activePlayer for a shot
                // Determine if it is a valid shot
                // Deterine shot results
                RecordPlayerShot(activePlayer, opponent);

                // Determine is the game should continue
                bool doesGameContinue = GameLogic.PlayerStillActive(opponent);

                // If over, set player1 as the winner
                // esle, swap positions (activePlayer to oppent)
                if ( doesGameContinue == true)
                {
                    // Swap using a temp variable
                    //PlayerInfoModel tempHolder = opponent;
                    //opponent = activePlayer;
                    //activePlayer = tempHolder;

                    // Use Tuple, Swap positions
                    (activePlayer, opponent) = (opponent, activePlayer);
                }
                else
                {
                    winner = activePlayer;
                }

            } while (winner == null);

            IdentifyWinner(winner);

            Console.ReadLine();
        }
        private static void IdentifyWinner(PlayerInfoModel winner)
        {
            Console.WriteLine($"Congratulations to { winner.UsersName } for winning!");
            Console.WriteLine($"{ winner.UsersName } took { GameLogic.GetShotCount(winner) } shots.");
        }
        private static void RecordPlayerShot(PlayerInfoModel activePlayer, PlayerInfoModel opponent)
        {
            // asks for a shot ( do we ask for "B2" or "B" and then "2" ): B2
            // determine what row and column that is - split it apart
            // determine if that is a valid shot
            // Go back to the beginning if not a valid shot.

            bool isValidShot = false;
            string row = "";
            int column = 0;
            do
            {
                string shot = AskForShot(activePlayer);
                try
                {
                    (row, column) = GameLogic.SplitShotIntoRowAndColumn(shot);
                    isValidShot = GameLogic.ValidateShot(activePlayer, row, column);
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("Error: " + ex.Message);
                    isValidShot = false;
                }

                if( isValidShot == false)
                {
                    Console.WriteLine("Invalid Shot Location. Please try again.");
                }

            } while ( isValidShot == false );

            // Determine shot result
            bool isAHit = GameLogic.IdentifyShotResult(opponent, row, column);

            // Record result.
            GameLogic.MarkShotResult(activePlayer, row, column, isAHit);
        }
        private static string AskForShot(PlayerInfoModel player)
        {
            Console.Write($"{player.UsersName}, Please enter your shot selection: ");
            string output = Console.ReadLine();

            return output;
        }
        private static void DisplayShotGrid(PlayerInfoModel activePlayer)
        {
            string currentRow = activePlayer.ShotGrid[0].SpotLetter;
            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                if ( gridSpot.SpotLetter != currentRow )
                {
                    Console.WriteLine();
                    currentRow = gridSpot.SpotLetter;
                }
                if ( gridSpot.Status == GridSpotStatus.Empty )
                {
                    Console.Write($" { gridSpot.SpotLetter }{ gridSpot.SpotNumber } ");
                }
                else if ( gridSpot.Status == GridSpotStatus.Hit )
                {
                    Console.Write(" X  ");
                }
                else if ( gridSpot.Status == GridSpotStatus.Miss )
                {
                    Console.Write(" O  ");
                }
                else
                {
                    Console.Write( " ?  " );
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Battleship Lite");
            Console.WriteLine("created by Yi Long");
            Console.WriteLine();
        }
        private static PlayerInfoModel CreatePlayer(string playerTitle)
        {
            PlayerInfoModel output = new PlayerInfoModel();

            Console.WriteLine($"Player Information For {playerTitle}");

            // Ask user for their name
            output.UsersName = AskForUsersName();

            // Load up the shot grid.nothing to do in the interface, so do it in the classlibrary
            GameLogic.InitializeGrid(output);

            // Ask the user for their 5 ship placements
            PlaceShips(output);

            // Clear the screen
            Console.Clear();

            return output;
        }
        private static string AskForUsersName()
        {
            Console.Write("What is your name: ");
            string output = Console.ReadLine();

            return output;
        }
        private static void PlaceShips(PlayerInfoModel model)
        {
            do
            {
                Console.Write($"Where do you place ship number { model.ShipLocations.Count + 1 }: ");
                string location = Console.ReadLine();

                bool isValidLocation = false;
                try
                {
                    isValidLocation = GameLogic.PlaceShip(model, location);
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error: " + ex.Message);
                }
                

                if ( isValidLocation == false)
                {
                    Console.WriteLine("That was not a valid location. Please try again.");
                }
            } while (model.ShipLocations.Count < 5);
        }
    }
}
