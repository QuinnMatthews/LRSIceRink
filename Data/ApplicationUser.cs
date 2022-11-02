using System.ComponentModel.DataAnnotations;
using Blazorise;
using LRSIceRink.Data;
using Microsoft.AspNetCore.Identity;

namespace LRSIceRink.Data {
    public class ApplicationUser : IdentityUser, IComparable {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public ICollection<ApplicationUserRole> UserRoles { get; set; }
        public virtual List<AuditLog> AuditHistory { get; set; }

        //Returns first + last name if possible, if no last name, returns only first, and if neither, returns email
        public string GetNameReference()
        {
            if (FirstName is not null && LastName is not null)
            {
                return $"{FirstName} {LastName}";
            } else if (FirstName is not null && LastName is not null)
            {
                return FirstName;
            }
            else
            {
                return Email;
            }
        }
        public int CompareTo(object incomingobject) {
            ApplicationUser incominguser = incomingobject as ApplicationUser;

            return this.Id.CompareTo(incominguser.Id);
        }
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
