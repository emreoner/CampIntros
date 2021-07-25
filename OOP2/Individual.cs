using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Bireysel gercek musteri de bir musteridir
    class Individual:Customer
    {
        public string IdentityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
    }
}
