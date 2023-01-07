using System;

namespace ConsoleUI
{
    public class SecondType : ITester
    {
        public bool hasBattery { get; set; }
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



