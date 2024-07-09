using Microsoft.AspNetCore.Identity;

namespace ConstructionPortal.Models.DataModels
{
    public class User: IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
