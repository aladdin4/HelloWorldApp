using System;

namespace ConsoleUI
{
    public abstract class BaseType : ITester
    {
        public  bool hasBattery { get; set; }
        public bool Added()
        {
            return true;
        }
        public void printMeFirst(string name) {
            Console.WriteLine(name + "is called !! from the deepest class");
        }

        public abstract string OverRideMe();
        public virtual void OverRideMeToo() { 
        
        }
    }

}



