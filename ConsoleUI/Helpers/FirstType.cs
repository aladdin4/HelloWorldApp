
using System;

namespace ConsoleUI
{
    public class FirstType : BaseType
    {
        public string name { get; set; }
        public int age { get; set; }

      
        public override string OverRideMe()
        {
            throw new NotImplementedException();
        }
        public override void OverRideMeToo()
        {

        }
        public void printMeSecond(string name)
        {
            Console.WriteLine("the specific type method inside the first type class" + name);

        }
        
    }

}



