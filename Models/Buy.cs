using ASP_Project.Models.Base;
using System.Diagnostics;

namespace ASP_Project.Models
{
    public class Buy : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public int Price { get; set; } = 0;

        public Guid MagazineID { get; set; }

        public Guid PersonID { get; set; }

        public Comics Comic { get; set; } = default!;

        public string BuyDate { get; set; } = string.Empty;

        public int NumberOfUnitsSold { get; set; } = default!;

        public User NewUser { get; set; } = new User();

        public List<Comics> Comics { get; set; } = new List<Comics>();
    }
}
