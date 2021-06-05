using System;

namespace M05L04BattleshipLiteLibrary.Models
{
    public class GridSpotModel{
        public string SpotLetter { get; set; }
        public int SpotNumber { get; set; }
        // public int Status { get; set; } // 0=empy, 1- ship, 2-miss, 3=hit, 4=sunk
        public GridSpotStatus Status { get; set; } = GridSpotStatus.Empty;

    }
}