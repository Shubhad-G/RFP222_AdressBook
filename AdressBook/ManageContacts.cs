using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    internal class ManageContacts
    {
       public List<Contacts> adressBook = new List<Contacts>();
        public Contacts contact;
        IDictionary<string, List<Contacts>> addressBookNames = new Dictionary<string, List<Contacts>>();
        public void addContact(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                contact = new Contacts();
                Console.WriteLine("\nenter the First Name:");
                contact.firstName = Console.ReadLine();

                Console.WriteLine("enter the Last Name:");
                contact.lastName = Console.ReadLine();


                Console.WriteLine("enter the email:");
                contact.email = Console.ReadLine();


                Console.WriteLine("enter the phone no:");
                contact.phone = Console.ReadLine();


                Console.WriteLine("enter the city name:");
                contact.city = Console.ReadLine();


                Console.WriteLine("enter the State:");
                contact.state = Console.ReadLine();


                Console.WriteLine("enter the zip code:");
                contact.zip = Console.ReadLine();


                Console.WriteLine("enter the country:");
                contact.country = Console.ReadLine();

                adressBook.Add(contact);
            }   
        }
        public void addAddressBooks()
        {
            Console.WriteLine("enter Book name");
            string name = Console.ReadLine();
            addressBookNames.Add(name,adressBook);
           
        }

        public void displayAddressBooks()
        {
            foreach (var i in addressBookNames.Keys)
            {
                Console.WriteLine("\nAddress Book Name:{0}\nContacts\n", i);
                foreach(Contacts c in addressBookNames[i])
                {
                    Console.WriteLine("\nFirst Name:"+c.firstName+"\nLast Name:"+c.lastName+"\nPhone No:"+c.phone+"\nEmail:"+c.email+"\nState:"+c.state+"\nCity:"+c.city+"\nZip:"+c.zip+"\nCountry:"+c.country+"\n");
                }
            }
            
        }
        public void displayContact()
        {
            
            foreach(Contacts c in adressBook)
            {
                Console.WriteLine("\nFirst Name:" + c.firstName + "\nLast Name:" + c.lastName + "\nPhone No:" + c.phone + "\nEmail:" + c.email + "\nState:" + c.state + "\nCity:" + c.city + "\nZip:" + c.zip + "\nCountry:" + c.country + "\n");
            }
        }
        public void editContact(string name)
        {
            if (name == contact.firstName)
            {
                string editFirstName;
                Console.WriteLine("enter the first name");
                editFirstName = Console.ReadLine();
                contact.firstName = editFirstName;
                string editLastName;
                Console.WriteLine("enter the last name");
                editLastName = Console.ReadLine();
                contact.lastName = editLastName;
                string editEmail;
                Console.WriteLine("enter the email");
                editEmail = Console.ReadLine();
                contact.email = editEmail;
                string editPhone;
                Console.WriteLine("enter the phoneno");
                editPhone = Console.ReadLine();
                contact.phone = editPhone;
                string editCity;
                Console.WriteLine("enter the city");
                editCity = Console.ReadLine();
                contact.city = editCity;
                string editState;
                Console.WriteLine("enter the State");
                editState = Console.ReadLine();
                contact.state = editState;
                string editZip;
                Console.WriteLine("enter the zip code");
                editZip = Console.ReadLine();
                contact.zip = editZip;
                string editCountry;
                Console.WriteLine("enter the country name");
                editCountry = Console.ReadLine();
                contact.country = editCountry;
            }
            else
                Console.WriteLine("Entered Name does not exist in the address book");
        }
        public void deleteContact(string name)
        {
            if (name == contact.firstName)
            {
                adressBook.Remove(contact);
            }
            else
                Console.WriteLine("Entered Name does not exist in the address book");
        }
    }
}
