using ASP_Project.Models.Base;

namespace ASP_Project.Models
{
    public class Rent : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string DateStart { get; set; } = string.Empty;

        public string DateEnd { get; set; } = string.Empty;

        public int PricePerDay { get; set; } = 5;

        public Guid MagazineID { get; set; }

        public Guid PersonID { get; set; }

        public Comics Comic { get; set; } = new Comics();

        public User NewUser { get; set; } = new User();

    }
}
