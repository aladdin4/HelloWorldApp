using System;
using System.Collections.Generic;
using System.Text;

namespace BattlefieldGameLibrary
{
    /// <summary>
    /// the spot definition of single spot(cell) on the grid
    /// </summary>
    /// 
    public class GridSpot
    {
        public string SpotName { get; set; }
        public int SpotNumber { get; set; }
        public string SpotLetter { get; set; }
        public SpotStatus Status { get; set; }
        public GridSpot()
        {

        }
        public GridSpot(string name)
        {
            string letter = char.ToString(name[0]);
            int number = int.Parse(char.ToString(name[1]));
            
            if (number < 0 || number > 5)
            {
                throw new Exception("spot number has to be between 0 and 5");
               
            }
            letter = letter.ToUpper();
            if (letter == "A" || letter == "B" || letter == "C" || letter == "D" || letter == "E")
            {
                SpotName = name;
                SpotNumber = number;
                SpotLetter = letter;
                Status = SpotStatus.Empty;
            }
            else
            {
                throw new Exception("spot letter has to be between A and E");
            }
            

        }
    }
}
