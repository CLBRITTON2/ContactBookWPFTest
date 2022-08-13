using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string WorkPhoneNumber { get; set; }
        public string Address { get; set; }

        public Person()
        {
            FirstName = String.Empty;
            LastName = String.Empty;
            MobilePhoneNumber = String.Empty;
            WorkPhoneNumber = String.Empty;
            Address = String.Empty;
        }
    }
}
