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
            ManageContacts.addContact();

           /* foreach (var a in adressBook)
            {
                Console.WriteLine(a.firstName);
            }*/

            Console.ReadLine();
        }
    }
}
