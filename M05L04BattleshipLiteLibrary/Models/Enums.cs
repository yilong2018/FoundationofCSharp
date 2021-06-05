using System;

namespace M05L04BattleshipLiteLibrary.Models
{
    // 0=empy, 1- ship, 2-miss, 3=hit, 4=sunk
    public enum GridSpotStatus{
        Empty,
        Ship,
        Miss,
        Hit,
        Sunk
    }
}