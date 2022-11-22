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

            ManageContacts add = new ManageContacts();
            
            Console.WriteLine("Options for AdressBook\n1.Add Contact\n2.Edit an Existing Contact\n3.delete an existing contact");
            add.addContact();//adding contact to the address book
           
            Console.WriteLine("enter the first name you want to edit");//editing contact
                        string name = Console.ReadLine();
                        add.editContact(name);

            Console.WriteLine("enter the first name of the contact you want to delete");//deleting contact
                name = Console.ReadLine();
                add.deleteContact(name);
            Console.ReadLine();

             
           /* foreach (var a in adressBook)
            {
                Console.WriteLine(a.firstName);
            }
           */

        }
    }
}
