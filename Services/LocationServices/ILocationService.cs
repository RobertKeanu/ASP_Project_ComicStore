using ASP_Project.Models;

namespace ASP_Project.Services.LocationServices
{
    public interface ILocationService
    {
        Task Create(Location location);
        Task Delete(Location location);

        IAsyncEnumerable<Location> GetAsync();
        Guid GetLocation(string country, string city, string street);
    }
}
