using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact
    {
        public String firstName;
        public String lastName;
        public String address;
        public String city;
        public String state;
        public String zip;
        public String phoneNumber;
        public String email;
        //consstructor
        public Contact(String firstName, String lastName, String address, String city, String state, String zip, String phone, String email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public String toString()
        {
            return "first Name=" + firstName + ",last name=" + lastName + ",address="
                        + address + ",city=" + city + ",state=" + state + ",zip" +
                        zip + ",phone number=" + phoneNumber + "email=" + email;
        }
    }
}
