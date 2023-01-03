using System;
using System.Collections.Generic;

namespace BattlefieldGameLibrary
{
    public class PlayerInfo
    {
        public string Name { get; set; }
        public List<GridSpot> ShipsPlacement { get; set; }
        public List<GridSpot> ShotHistory { get; set; }
        public int Army { get; set; }
        public int PlayerID { get; set; }
        public PlayerInfo(string name, List<GridSpot> places, int ID)
        {
            Name = name;
            ShipsPlacement = places;
            ShotHistory = new List<GridSpot>();
            PlayerID = ID;
        }
        public PlayerInfo(string name)
        {
            Name = name;
        }
    }
}
