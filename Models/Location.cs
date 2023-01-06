using ASP_Project.Models.Base;

namespace ASP_Project.Models
{
    public class Location : BaseEntity
    {
        public string Country { get; set; } = string.Empty;

        public string Region { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Street { get; set; } = string.Empty;

        public int NumberStore { get; set; } = default;

        public ComicStore ComicStore { get; set; } = default!;


    }
}
