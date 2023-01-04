using System;
using System.Collections.Generic;
using BattlefieldGameLibrary;
using PeopleLibrary;
using PeopleLibrary.Places;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to my App.");
            Console.WriteLine("working.");
            List<ITester> myList = new List<ITester>();
            myList.Add(new FirstType());
            myList.Add(new SecondType());

            foreach (var item in myList)
            {
             //   item.
            }


            //keeping that here always.
            Console.ReadLine();

            ///////////////////////////////////////////////////////////////////////////////////////////////////
            /////the people app start
            //////////
            ///
            //// get the data
            //List<Person> people = PeopleHandler.getData();
            /////
            //// print the data
            //PeopleHandler.printData(people);
            /////
            ///////////
            /////the people app end
            ////////////////////////////////////////////////////////////////////////////////////////////////////




            ///// the mid term project: battlefield game
            //Console.WriteLine("Welcome to Battlefield console game");
            //PlayerInfo firstPlayer = PlayersHandler.CreatePlayer(1);
            //PlayerInfo secondPlayer = PlayersHandler.CreatePlayer(2);

            //bool gameOn = true;
            //while (gameOn)
            //{
            //    gameOn = GameActions.fire(firstPlayer, secondPlayer);
            //    if (gameOn)
            //    {
            //        gameOn = GameActions.fire(secondPlayer, firstPlayer);
            //    }
            //}
            //Console.Write("game over");

            //Console.WriteLine("Bye Bye.");
            ///////////////////////////////////////////////////////////////////////////////////
            ///
            /// 
            ///////////////////////////////////////////////////////////////////////////////////
            /////testing swap
            //PlayerInfo x = new PlayerInfo("x");
            //PlayerInfo y = new PlayerInfo("y");
            //Console.WriteLine($"x is: {x.Name}");
            //Console.WriteLine($"y is: {y.Name}");
            ////using tuples
            //(x, y) = (y, x);
            //Console.WriteLine($"x is: {x.Name}");
            //Console.WriteLine($"y is: {y.Name}");

            //PlayerInfo temp = x;
            //temp.Name = "changed";
            //Console.WriteLine(x.Name);

            //y = temp;
            ///////////////////////////////////////////////////////////////////////////////////
            ///





        }
    }

    public interface ITester
    {
        void printMeFirst(string name);
    }

    public class FirstType : ITester
    {
        public void printMeFirst(string name)
        {
            Console.WriteLine("inside the first type class");
        }
        public void printMeSecond(string name)
        {
            Console.WriteLine("the specific type method inside the first type class");

        }
    }

    public class SecondType : ITester
    {
        public void printMeFirst(string name)
        {
            Console.WriteLine("inside the second type class");
        }
        public void printMethird(string name)
        {
            Console.WriteLine("the specific type method inside the second type class");
        }
    }

}



