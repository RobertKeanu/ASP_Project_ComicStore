using ASP_Project.Models.Base;

namespace ASP_Project.Models
{
    public class Comics : BaseEntity
    {
        public string ComicsName { get; set; } = string.Empty;

        public string ComicsDescription { get; set; } = string.Empty;

        public int ComicsPrice { get; set; }

        public string ComicsType { get; set; } = string.Empty;

        public ComicStore ComicStore { get; set; } = new ComicStore();

        public Guid ComicID { get; set; }

        public Guid ComicStoreID { get; set; }

        public List<Buy> Buys { get; set; } = new List<Buy>();

        public List<Rent> Rents { get; set; } = new List<Rent>();

    }
}
