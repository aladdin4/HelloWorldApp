using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleLibrary.Places
{
    public class Address
    {
        public string AddressType { get; set; }

        public static void SetAddress(string address, string addressType, Person p)
        {
            p.PersonAddress = address;
            p.AddressType = addressType;
        }
    }
}

