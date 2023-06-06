
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to Address Book");

            Console.WriteLine("Enter the option to use case to execute\n 1:Ability to create a contact\n 2:Add a new contact to Address book\n3:Ability to Edit existing condtact\n4:Ability to Delete contact using person's name\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Able to create a contact list ");
                    //created a Contacts class
                    break;
                case 2:
                    Console.WriteLine("Enter first name = ");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter last name = ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter address= ");
                    String address = Console.ReadLine();
                    Console.WriteLine("Enter city= ");
                    String city = Console.ReadLine();
                    Console.WriteLine("Enter state= ");
                    String state = Console.ReadLine();
                    Console.WriteLine("Enter zip= ");
                    String zip = Console.ReadLine();
                    Console.WriteLine("Enter phoneNumber= ");
                    String phoneNumber = Console.ReadLine();
                    Console.WriteLine("Enter email= ");
                    String email = Console.ReadLine();
                    AddressBook builder = new AddressBook();
                    builder.AddContacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
                    Console.WriteLine("\n************** Contact Details are ************");
                    builder.DisplayContact();
                    builder.EditContact();
                    builder.DisplayContact();
                    break;
                default:
                    break;



            }
        }
    }
}