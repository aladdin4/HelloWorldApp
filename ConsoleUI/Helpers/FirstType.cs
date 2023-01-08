
using System;

namespace ConsoleUI
{
    public class FirstType
    {
        public string name { get; set; }
        public int age { get; set; }

        public void printMeFirst(string name)
        {
            Console.WriteLine("inside the first type class" + name);
            BaseType val = new BaseType();
            val.hasBattery = true;

        }
        public void printMeSecond(string name)
        {
            Console.WriteLine("the specific type method inside the first type class" + name);

        }
        
    }

}



