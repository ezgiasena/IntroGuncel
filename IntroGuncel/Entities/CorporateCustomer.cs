using System.Security.Principal;

namespace IntroGuncel.Entities
{
    public class CorporateCustomer : BaseCustomer
    {
        
        
        public string  Name { get; set; }

        public string TaxNumber  { get; set; }
    }
}
