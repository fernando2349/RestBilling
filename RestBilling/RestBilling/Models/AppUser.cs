using Microsoft.AspNetCore.Identity;

namespace RestBilling.Models
{
    public class AppUser : IdentityUser 
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; internal set; }
    }
}
