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
            addressBook.First_Name = "vaibhavi";
            addressBook.Last_Name = "ghare";
            addressBook.Phone_Number = 2435623;
            addressBook.City = "pune";
            AddressRepository.AddEmployee(addressBook);
            Console.ReadLine();
        }
    }
}
