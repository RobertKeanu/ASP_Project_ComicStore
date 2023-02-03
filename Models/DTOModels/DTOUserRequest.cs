using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ASP_Project.Models.DTOModels
{
    public class DTOUserRequest
    {
        [Required]
        public required string Name { get; set; }

        [Required]

        public required string Email { get; set; }

        [Required]
        public required string Password { get; set; }

        [Required]
        public required string PhoneNumber { get; set; }

        [Required]
        public required string Preferences { get; set; }
    }
}
