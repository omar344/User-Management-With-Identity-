using Microsoft.AspNetCore.Identity;
using System.Diagnostics.CodeAnalysis;

namespace UserManagmentWithIdentity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [AllowNull]
        public byte[] ProfilePicture { get; set; }
    }
}
