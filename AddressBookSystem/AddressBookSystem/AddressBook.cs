
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBook : IContacts
    {
        public List<Contact> contactList;

        public AddressBook()
        {
            this.contactList = new List<Contact>();
        }

        public void addContact(String firstName, String lastName, String address, String city, String state, String zip, String phoneNumber, String email)
        {
            bool duplicate = equals(firstName);
            if (!duplicate)
            {
                Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
                contactList.Add(contact);
            }
            else
            {
                Console.WriteLine("Cannot add duplicate contacts first name");
            }
        }

        private bool equals(string firstName)
        {
            if (this.contactList.Any(e => e.FirstName == firstName))
                return true;
            else
                return false;
        }

        public void editContact(string firstName)
        {
            int flag = 1;
            foreach (Contact contact in contactList)
            {
                if (firstName.Equals(contact.FirstName))
                {
                    flag = 0;
                    Console.WriteLine("Please select the area of editing \n" +
                        "1)First Name\n2)Last Name\n3)Address\n4)Phone Number\n5)Email_Id");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Please enter your first name : ");
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Please enter your last name : ");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Please enter your Address : ");
                            contact.Address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Please enter your Phone Number : ");
                            contact.PhoneNum = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Please enter your email Id: ");
                            contact.Email = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Entered an Invalid input\n try again");
                            break;
                    }
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Contact not found");
            }
        }

        public void deleteContact(string firstName)
        {
            int flag = 1;
            foreach (Contact contact in contactList)
            {
                if (firstName.Equals(contact.FirstName))
                {
                    flag = 0;
                    contactList.Remove(contact);
                    Console.WriteLine("Sucessfully deleted");
                    break;
                }
            }
            if (flag == 1)
            {
                Console.WriteLine("Contact not found");
            }
        }

        public void displayContact()
        {
            foreach (Contact contact in contactList)
            {
                Console.WriteLine("\nFirst name = " + contact.FirstName);
                Console.WriteLine("Last name = " + contact.LastName);
                Console.WriteLine("Address = " + contact.Address);
                Console.WriteLine("city = " + contact.City);
                Console.WriteLine("state = " + contact.State);
                Console.WriteLine("zip = " + contact.Zip);
                Console.WriteLine("phoneNumber = " + contact.PhoneNum);
                Console.WriteLine("email = " + contact.Email);
            }
        }
    }
}
