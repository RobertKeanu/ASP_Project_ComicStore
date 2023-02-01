using ASP_Project.Models.Base;
using ASP_Project.Models.Base.Roles;

namespace ASP_Project.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        
        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string DateOfBirth { get; set; } = string.Empty;

        public string Preferences { get; set; } = string.Empty;

        public List<Rent> Rents { get; set; } = new List<Rent>();

        public Roles Role { get; set; } = default!;

        public Comics? Comic { get; set; }

        public Roles RoleName { get; set; } = default!;

        public List<Buy> Buys { get; set; } = new List<Buy>();
    }
}
