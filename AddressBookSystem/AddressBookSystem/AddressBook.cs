
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook
    {
        public List<Contact> ContactsList;
        Dictionary<string, List<Contact>> addressBookDictionary = new Dictionary<string, List<Contact>>();
        public AddressBook()
        {
            this.ContactsList = new List<Contact>();
        }
        public void AddContacts(String firstName, String lastName, String address, String city, String state, String zip, String phone, String email)
        {
            Contact contact = new Contact(firstName, lastName, address, city, state, zip, phone, email);
            this.ContactsList.Add(contact);
        }
        public void AddContacts()
        {
            Console.WriteLine("How many persons contacts you want to add to address book");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Enter first name = ");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter last name = ");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter address= ");
                string address = Console.ReadLine();
                Console.WriteLine("Enter city= ");
                string city = Console.ReadLine();
                Console.WriteLine("Enter state= ");
                string state = Console.ReadLine();
                Console.WriteLine("Enter zip= ");
                string zip = Console.ReadLine();
                Console.WriteLine("Enter phoneNumber= ");
                string phoneNumber = Console.ReadLine();
                Console.WriteLine("Enter email= ");
                string email = Console.ReadLine();
                Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
                ContactsList.Add(contact);
                Console.WriteLine("contact added succesfully");
            }
        }
        public void DisplayContact()
        {
            foreach (Contact contact in this.ContactsList)
            {
                Console.WriteLine("First Name = " + contact.FirstName);
                Console.WriteLine("Last Name = " + contact.LastName);
                Console.WriteLine("Address = " + contact.Address);
                Console.WriteLine("City  = " + contact.City);
                Console.WriteLine("State = " + contact.State);
                Console.WriteLine("Zip code  = " + contact.Zip);
                Console.WriteLine("Phone number  = " + contact.PhoneNum);
                Console.WriteLine("Email ID  = " + contact.Email);
            }
        }
        public void EditExistingContact()
        {
        search:
            Console.WriteLine("\nEnter first name of the person for editing contact");
            String firstname = Console.ReadLine();
            bool findContact = false;
            foreach (Contact contact in this.ContactsList)      //Iterating contacts iin list
            {
                //Checking the existatnce of the person name in contact list
                if (contact.FirstName == firstname)
                {
                ReCheck:
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
                            goto ReCheck;
                    }
                    Console.WriteLine("Contact edited succesfully");
                    findContact = true;
                }
            }
            if (!findContact)
            {
                Console.WriteLine("*** Wrong Input ***: please enter a valid First name\n Enter Y/N");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    goto search;
                }
            }
        }
        public void DeleteExistingContact()
        {
            bool delete = false;
            Console.WriteLine("\nEnter first name of the person for deleting contact");
            String firstname = Console.ReadLine();
            foreach (Contact contact in this.ContactsList)      //Iterating contacts in list
            {
                //Checking the existatnce of the person name in contact list
                if (contact.FirstName == firstname)
                {
                    this.ContactsList.Remove(contact);
                    delete = true;
                    break;
                }
            }
            if (!delete)
                Console.WriteLine("*** Wrong Input ***: please enter a valid First name");
        }
    }
}
