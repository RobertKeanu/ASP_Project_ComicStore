using System.ComponentModel.DataAnnotations;

namespace ASP_Project.Models.DTOModels
{
    public class DTOUserRequired
    {
        [Required]
        public required string Name { get; set; }

        [Required]

        public required string Email { get; set; }

        [Required]
        public required string Password { get; set; }
    }
}
