using BattlefieldGameLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public static class GameActions
    {
        public static bool fire(PlayerInfo shootingPlayer, PlayerInfo receivingPlayer)
        {
            bool gameOn = true;

            Console.WriteLine($"for player #{shootingPlayer.PlayerID} to take his shot please: ");
            string position = Console.ReadLine();
            bool validShot = true;

            GridSpot spot = new GridSpot(position);

            foreach (var singleSpot in shootingPlayer.ShotHistory)
            {
                if (singleSpot.SpotName == spot.SpotName)
                {
                    validShot = false;
                }
            }
            foreach (var singleSpot in shootingPlayer.ShipsPlacement)
            {
                if (singleSpot.SpotName == spot.SpotName)
                {
                    validShot = false;
                }
            }

            if (validShot)
            {
                GridSpot toRemove = new GridSpot();
                shootingPlayer.ShotHistory.Add(spot);
                foreach (var singleSpot in receivingPlayer.ShipsPlacement)
                {
                    if (singleSpot.SpotName == spot.SpotName)
                    {
                        Console.WriteLine("it HIT !");
                        toRemove = singleSpot;
                    }
                }
                receivingPlayer.ShipsPlacement.Remove(toRemove);

                Console.WriteLine($"current player {shootingPlayer.PlayerID} status is {shootingPlayer.ShipsPlacement.Count}");
                Console.WriteLine($"current player {receivingPlayer.PlayerID} status is {receivingPlayer.ShipsPlacement.Count}");

                if (receivingPlayer.ShipsPlacement.Count == 0)
                {
                    gameOn = false;
                    Console.WriteLine("winner is player 1");
                }
            }
            else
            {
                Console.WriteLine("you lost a turn !");
            }
            
            return gameOn;
        }
    }
}
