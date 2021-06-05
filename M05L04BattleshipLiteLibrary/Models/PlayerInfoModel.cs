using System;
using System.Collections.Generic;

namespace M05L04BattleshipLiteLibrary.Models
{
    public class PlayerInfoModel{
        public string UserName { get; set; }
        public List<GridSpotModel> shipLocations { get; set; }
        public List<GridSpotModel> ShotGrid { get; set; }
    }
}