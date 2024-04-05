using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addressbook
{
    public  class Program
    {
        static void Main(string[] args) 
        {
            AddressBook addressBook = new AddressBook();
            addressBook.AddDetails();
            Console.WriteLine("i u want add another addressbook press 1 or if not press 0");
            int choice=int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                addressBook.AddDetails();
            }
            
            
            addressBook.Display();

        }
    }
}
