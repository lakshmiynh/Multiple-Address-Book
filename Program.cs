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
            addressBook.Display();

            Console.WriteLine("add anothe addressbook");
            addressBook.AddDetails();
            addressBook.Display();

        }
    }
}
