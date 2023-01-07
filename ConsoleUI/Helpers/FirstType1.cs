using System;

namespace ConsoleUI
{
    public class FirstType : BaseType, ITester
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

}



