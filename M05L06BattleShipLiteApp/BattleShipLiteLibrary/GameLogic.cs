using BattleShipLiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipLiteLibrary
{
    public static class GameLogic
    {
        public static void InitializeGrid(PlayerInfoModel model)
        {
            List<string> letters = new List<string>
            {
                "A",
                "B",
                "C",
                "D",
                "E"
            };
            List<int> numbers = new List<int>
            {
                1,
                2,
                3,
                4,
                5
            };
            foreach (string letter in letters)
            {
                foreach (int number in numbers)
                {
                    AddGridSpot(model, letter, number);
                }
            }
        }
        
        private static void AddGridSpot(PlayerInfoModel model, string letter, int number)
        {
            GridSpotModel spot = new GridSpotModel();
            spot.SpotLetter = letter;
            spot.SpotNumber = number;
            spot.Status = GridSpotStatus.Empty;

            model.ShotGrid.Add(spot);
        }

        public static bool PlayerStillActive(PlayerInfoModel opponent)
        {
            bool isActive = false;
            
            foreach (GridSpotModel ship in opponent.ShipLocations)
            {
                if (ship.Status != GridSpotStatus.Sunk )
                {
                    isActive = true;
                }
            }

            return isActive;
            
        }

        public static bool PlaceShip(PlayerInfoModel model, string location)
        {
            bool output = false;
            (string row, int column) = SplitShotIntoRowAndColumn(location);
            bool isValiLocation = ValidateGridLocation(model, row, column);
            bool isSpotOpen = VadlidateShipLocation(model, row, column);

            if ( isValiLocation && isSpotOpen )
            {
                model.ShipLocations.Add(new GridSpotModel
                {
                    SpotLetter = row.ToUpper(),
                    SpotNumber = column,
                    Status = GridSpotStatus.Ship
                });

                output = true;
            }

            return output;
        }

        private static bool VadlidateShipLocation(PlayerInfoModel model, string row, int column)
        {
            bool isValidLocation = true;
            foreach (GridSpotModel ship in model.ShipLocations)
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                    isValidLocation = false;
                }
            }
            return isValidLocation;
        }

        private static bool ValidateGridLocation(PlayerInfoModel model, string row, int column)
        {
            bool isValidLocation = false;
            foreach (GridSpotModel spot in model.ShotGrid)
            {
                if (spot.SpotLetter == row.ToUpper() && spot.SpotNumber == column)
                {
                    isValidLocation = true;
                }
            }
            return isValidLocation;
        }

        public static int GetShotCount(PlayerInfoModel winner)
        {
            int shotCount = 0;
            foreach (GridSpotModel shot in winner.ShotGrid)
            {
                if ( shot.Status != GridSpotStatus.Empty )
                {
                    shotCount += 1;
                }
            }
            return shotCount;
        }

        public static (string row, int column) SplitShotIntoRowAndColumn(string shot)
        {
            //string spotLetter = shot.Substring(0, 1);
            //int spotNumber = int.Parse(shot.Substring(1, 1));
            //return (spotLetter, spotNumber);
            string row = "";
            int column = 0;
            if ( shot.Length != 2)
            {
                throw new ArgumentException("This was an invalid shot type.", "shot");
            }
            char[] shotArray = shot.ToArray();
            row = shotArray[0].ToString();
            column = int.Parse(shotArray[1].ToString());

            return (row, column);
        }

        public static bool ValidateShot(PlayerInfoModel activePlayer, string row, int column)
        {
            bool isValidShot = false;
            foreach (GridSpotModel gs in activePlayer.ShotGrid)
            {
                if ( gs.SpotLetter == row.ToUpper() && gs.SpotNumber == column )
                {
                    if (gs.Status == GridSpotStatus.Empty)
                    {
                        isValidShot = true;
                    }
                }
            }
            return isValidShot;
        }

        public static bool IdentifyShotResult(PlayerInfoModel opponent, string row, int column)
        {
            //for (int i = 0; i < opponent.ShipLocations.Count; i++)
            //{
            //    if (opponent.ShipLocations[i].SpotLetter == row && opponent.ShipLocations[i].SpotNumber == column)
            //    {
            //        opponent.ShipLocations[i].Status = GridSpotStatus.Sunk;
            //        return true;
            //    }
            //}
            //return false;
            bool isValidShot = false;
            foreach (GridSpotModel ship in opponent.ShipLocations)
            {
                if (ship.SpotLetter == row.ToUpper() && ship.SpotNumber == column)
                {
                    isValidShot = true;
                    ship.Status = GridSpotStatus.Sunk;
                }
            }
            return isValidShot;
        }

        public static void MarkShotResult(PlayerInfoModel activePlayer, string row, int column, bool isAHit)
        {
            //for (int i = 0; i < activePlayer.ShotGrid.Count; i++)
            //{
            //    if (activePlayer.ShotGrid[i].SpotLetter == row && activePlayer.ShotGrid[i].SpotNumber == column)
            //    {
            //        if (isAHit)
            //        {
            //            activePlayer.ShotGrid[i].Status = GridSpotStatus.Hit;
            //        }
            //        else
            //        {
            //            activePlayer.ShotGrid[i].Status = GridSpotStatus.Miss;
            //        }
            //    }
            //}
            foreach (var gridSpot in activePlayer.ShotGrid)
            {
                if (gridSpot.SpotLetter == row.ToUpper() && gridSpot.SpotNumber == column)
                {
                    if (isAHit)
                    {
                        gridSpot.Status = GridSpotStatus.Hit;
                    }
                    else
                    {
                        gridSpot.Status = GridSpotStatus.Miss;
                    } 
                }
            }

            DsiplayShotResults(row, column, isAHit);
        }

        private static void DsiplayShotResults(string row, int column, bool isAHit)
        {
            if (isAHit)
            {
                Console.WriteLine($"{ row }{ column } is a Hit!");
            }
            else
            {
                Console.WriteLine($"{ row }{ column } is a miss!");
            }
            Console.WriteLine();
        }
    }
}
