using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookADO.NET
{
    public  class AddressBook
    {


        public string First_Name { get; set; }
        public string Last_Name  { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string state { get; set; }
        public int Zip_Code { get; set; }
        public long Phone_Number { get; set; }
        public string E_Mail { get; set; }
         public string AddressBook_Name { get; set; }
        public string AddressBook_Type { get; set; }
      

    }
}
