using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook
{
   public class AddressBook
    {
        public Dictionary<string, Details> Addressbook1 = new Dictionary<string, Details>();

        public void AddDetails()
        {
            Console.WriteLine("Enter your firstname");
            string firstname = Console.ReadLine();

            Console.WriteLine("Enter your lastname");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enter your address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter your city");
            string city = Console.ReadLine();

            Console.WriteLine("Enter your state");
            string state = Console.ReadLine();

            Console.WriteLine("Enter your zipcode");
            int zipcode = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your phonenumber");
            double phonenumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your emailid");
            string email = Console.ReadLine();


            Addressbook1.Add(firstname, new Details(firstname, lastname, address, city, state, zipcode, phonenumber, email));

            Display();
        }

        public void Display()
        {
            foreach (var pair in Addressbook1)
            {
                Console.WriteLine("Contact Details:");
                Console.WriteLine($"Firstname: {pair.Value.firstname}");
                Console.WriteLine($"Lastname: {pair.Value.lastname}");
                Console.WriteLine($"Address: {pair.Value.address}");
                Console.WriteLine($"City: {pair.Value.city}");
                Console.WriteLine($"State: {pair.Value.state}");
                Console.WriteLine($"Zipcode: {pair.Value.zipcode}");
                Console.WriteLine($"Phonenumber: {pair.Value.phonenumber}");
                Console.WriteLine($"Email: {pair.Value.email}");
                Console.WriteLine();
            }
        }
    }


}

