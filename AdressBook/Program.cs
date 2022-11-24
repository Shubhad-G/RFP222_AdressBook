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
            int n;//number of contacts
            int option;
            do
            {
                Console.WriteLine("Options for AdressBook\n1.Add Contact\n2.Edit an Existing Contact\n3.delete an existing contact\n.4.displayContact\n5.add AddressBook\n6.display AddressBook");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("enter how many contacts you want to add to the address book");
                        n = Convert.ToInt32(Console.ReadLine());
                        add.addContact(n);
                        break;//adding contact to the address book

                    case 4:
                        add.displayContact();
                        break;//displaying the contacts

                    case 2:
                        Console.WriteLine("enter the first name of the contact you want to edit");//editing contact
                        string name = Console.ReadLine();
                        add.editContact(name);
                        break;

                    case 3:
                        Console.WriteLine("enter the first name of the contact you want to delete");//deleting contact
                        name = Console.ReadLine();
                        add.deleteContact(name);
                        break;

                    case 5:
                        add.addAddressBooks();
                        break;

                    case 6:
                        add.displayAddressBooks();
                        break;

                }

            }while(option != 0);
           /* foreach (var a in adressBook)
            {
                Console.WriteLine(a.firstName);
            }
           */

        }
    }
}
