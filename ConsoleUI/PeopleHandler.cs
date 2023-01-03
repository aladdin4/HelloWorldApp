using System;
using System.Collections.Generic;
using System.Text;
using PeopleLibrary;
using PeopleLibrary.Places;

namespace ConsoleUI
{
    class PeopleHandler
    {

        public static List<Person> getData()
        {
            Console.WriteLine($"please register the first person:");
            bool another = false;
            List<Person> people = new List<Person>();

            do
            {
                Console.Write("please enter the person's first name: ");
                string firstName = Console.ReadLine();

                Console.Write("please enter the person's last name: ");
                string lastName = Console.ReadLine();

                Console.Write("please enter the person's age: ");
                int age = 0;
                int.TryParse(Console.ReadLine(), out age);

                Console.Write($"Is {firstName}{lastName} married (true/false)? ");
                bool isMarried = false;
                bool.TryParse(Console.ReadLine(), out isMarried);

                Console.Write("please enter the person's Address: ");
                string PersonAddress = Console.ReadLine();

                Console.Write("please enter the person's Address Type: ");
                string AddressType = Console.ReadLine();

                Console.Write($"Do you want to register another person?(true/false) ");
                bool.TryParse(Console.ReadLine(), out another);

                Person current = new Person(firstName, lastName, age, isMarried);

                Address.SetAddress(PersonAddress, AddressType, current);

                people.Add(current);
            } while (another);
            return people;
        }

        public static void printData(List<Person> people)
        {
            Console.WriteLine("the people you entered are:");

            foreach (Person p in people)
            {
                Console.Write($"the person: {p.FirstName} {p.LastName} is {p.Age} " +
                    $"years old and his {p.AddressType} address is {p.PersonAddress}");

                if (p.IsMarried)
                {
                    Console.Write($"and his marital status is Married");
                }
                else
                {
                    Console.Write($"and his marital status is Signle");
                }
                Console.WriteLine();
            }
        }
    }
}

