using AdressBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program in AddressBook Main class on START Master Branch");
            List<Contacts> adressBook = new List<Contacts>();
            Contacts contact = new Contacts();
            Console.WriteLine("enter the First Name:");
            contact.firstName=Console.ReadLine();
            adressBook.Add(contact);

            Console.WriteLine("enter the Last Name:");
            contact.lastName=Console.ReadLine();
            adressBook.Add(contact);

            Console.WriteLine("enter the email:");
            contact.email=Console.ReadLine();
            adressBook.Add(contact);

            Console.WriteLine("enter the phone no:");
            contact.phone=Console.ReadLine();
            adressBook.Add(contact);

            Console.WriteLine("enter the city name:");
            contact.city=Console.ReadLine();
            adressBook.Add(contact);

            Console.WriteLine("enter the State:");
            contact.state = Console.ReadLine();
            adressBook.Add(contact);

            Console.WriteLine("enter the zip code:");
            contact.zip=Console.ReadLine();
            adressBook.Add(contact);

            Console.WriteLine("enter the country:");
            contact.country=Console.ReadLine();
            adressBook.Add(contact);

            Console.ReadLine();
        }
    }
}
