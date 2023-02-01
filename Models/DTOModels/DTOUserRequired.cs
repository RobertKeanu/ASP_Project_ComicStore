using System.ComponentModel.DataAnnotations;

namespace ASP_Project.Models.DTOModels
{
    public class DTOUserRequired
    {
        [Required]
        public string? Name { get; set; }

        [Required]

        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
