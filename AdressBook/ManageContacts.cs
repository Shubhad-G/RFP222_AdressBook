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
        public void addContact(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                contact = new Contacts();
                Console.WriteLine("enter the First Name:");
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
        public void displayContact()
        {
            
            foreach(Contacts c in adressBook)
            {
                Console.WriteLine(c.firstName);
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
