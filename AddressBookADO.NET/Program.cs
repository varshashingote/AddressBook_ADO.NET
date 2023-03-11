using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO.NET
{
     public class Program
    {
        public static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            addressBook.First_Name = "Varsha";
            addressBook.City = "Pune";
            AddressRepository.UpdateEmployee(addressBook);
            Console.ReadLine();
        }
    }
}
