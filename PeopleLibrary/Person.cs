using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleLibrary
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }
        public string PersonAddress { get; set; }
        public string AddressType { get; set; }

        public Person(string firstName, string lastName, int age, bool isMarried)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IsMarried = isMarried;
        }
    }
}
