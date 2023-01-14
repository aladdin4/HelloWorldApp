using System;

namespace ConsoleUI
{
    public class SecondType : BaseType
    {
        public override string OverRideMe()
        {
            return "overridden";
        }

        public void printMethird(string name)
        {
            Console.WriteLine("the specific type method inside the second type class");
        }

        //one of the few real uses of the override feature
        public override string ToString()
        {
            return base.ToString();
        }
    }

}



