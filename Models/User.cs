using ASP_Project.Models.Base;
using ASP_Project.Models.Base.Roles;
using System.Text.Json.Serialization;

namespace ASP_Project.Models
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        
        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string DateOfBirth { get; set; } = string.Empty;

        public List<Rent> Rents { get; set; } = new List<Rent>();

        public string Preferences { get; set; } = default!;

        public Roles Role { get; set; } = default!;

        public Comics? Comic { get; set; }

        public List<Buy> Buys { get; set; } = new List<Buy>();

        [JsonIgnore]
        public string PasswordHash { get; set; } = default!;
    }
}
