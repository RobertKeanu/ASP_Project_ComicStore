using ASP_Project.Models.Base;

namespace ASP_Project.Models
{
    public class ComicStore : BaseEntity
    {
        public string ComicStoreName { get; set; } = string.Empty;

        public Location Location { get; set; } = new Location();

        public Guid ComicStoreID { get; set; }

        public Guid LocationID { get; set; }

        public List<Comics> Comics { get; set; } = new List<Comics> {new Comics() };

    }
}
