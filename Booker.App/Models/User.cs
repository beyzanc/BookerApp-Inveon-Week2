using Microsoft.AspNetCore.Identity;

namespace Booker.App.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; } 
    }
}
