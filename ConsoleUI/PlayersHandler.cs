using BattlefieldGameLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public static class PlayersHandler
    {
        public static PlayerInfo CreatePlayer(int playerNumber)
        {
            
            Console.Write($"please enter the player #{playerNumber} name: ");
            string playerName = Console.ReadLine();

            List<GridSpot> playerLocations = new List<GridSpot>();
        
            Console.Write($"please enter the player #{playerNumber} ship #1 location: ");
            string playerShip1 = Console.ReadLine();
            GridSpot ship1 = new GridSpot(playerShip1);
            playerLocations.Add(ship1);

            Console.Write($"please enter the player #{playerNumber} ship #2 location: ");
            string playerShip2 = Console.ReadLine();
            GridSpot ship2 = new GridSpot(playerShip2);
            playerLocations.Add(ship2);

            Console.Write($"please enter the player #{playerNumber} ship #3 location: ");
            string playerShip3 = Console.ReadLine();
            GridSpot ship3 = new GridSpot(playerShip3);
            playerLocations.Add(ship3);

            Console.Write($"please enter the player #{playerNumber} ship #4 location: ");
            string playerShip4 = Console.ReadLine();
            GridSpot ship4 = new GridSpot(playerShip4);
            playerLocations.Add(ship4);

            Console.Write($"please enter the player #{playerNumber} ship #5  location: ");
            string playerShip5 = Console.ReadLine();
            GridSpot ship5 = new GridSpot(playerShip5);
            playerLocations.Add(ship5);
            
            PlayerInfo newPlayer = new PlayerInfo(playerName, playerLocations, playerNumber);


            Console.Clear();
            return newPlayer;

            
        }
    }
}
