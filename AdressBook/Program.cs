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
            
            Console.WriteLine("Options for AdressBook\n1.Add Contact\n2.Edit an Existing Contact");
           
       
                    
                        add.addContact();
                       
     
                        Console.WriteLine("enter the name you want to edit");
                        string name = Console.ReadLine();
                        add.editContact(name);
      

             
           /* foreach (var a in adressBook)
            {
                Console.WriteLine(a.firstName);
            }
           */
        }
    }
}
