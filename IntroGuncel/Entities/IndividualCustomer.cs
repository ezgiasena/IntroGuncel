using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IntroGuncel.Entities
{
    internal class IndividualCustomer : BaseCustomer
    {
       
       
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public string NationalIdentity { get; set; }
    }
}
