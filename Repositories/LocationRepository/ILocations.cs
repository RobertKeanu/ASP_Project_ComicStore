using ASP_Project.Models;
using ASP_Project.Repositories.GenericRepository;

namespace ASP_Project.Repositories.Locations
{
    public interface ILocations : IGenericRepository<Location>
    {
        Guid FindLocation (string country, string city, string street);
    }
}
