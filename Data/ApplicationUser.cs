using System.ComponentModel.DataAnnotations;
using Blazorise;
using Microsoft.AspNetCore.Identity;

namespace LRSIceRink.Data {
    public class ApplicationUser : IdentityUser {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public ICollection<ApplicationUserRole> UserRoles { get; set; }

    }
    public class ApplicationUserRole : IdentityUserRole<string>
    {
        public virtual ApplicationUser User { get; set; }
        public virtual ApplicationRole Role { get; set; }
    }

    public class ApplicationRole : IdentityRole
    {
        public ICollection<ApplicationUserRole> UserRoles { get; set; }

        public ApplicationRole() : base()
        {

        }
        public ApplicationRole(string role) : base(role)
        {
        }
    }
}
