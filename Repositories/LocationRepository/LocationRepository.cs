using ASP_Project.Models;
using ASP_Project.Repositories.GenericRepository;
using ASP_Project.Data;

namespace ASP_Project.Repositories.Locations
{
    public class Locations : GenericRepository<Location>, ILocations
    {
        public Locations(DataBaseContext context) : base(context) { }
        public Guid FindLocation(string country, string city, string street)
        {
            var loc = _table.FirstOrDefault(o => o.Country == country && o.City == city && o.Street == street);
            if (loc == null)
                return Guid.Empty;
            return loc.Id;
        }
    }
}
