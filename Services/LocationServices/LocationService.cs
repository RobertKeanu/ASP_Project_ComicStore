using ASP_Project.Models;
using ASP_Project.Repositories;
using ASP_Project.Repositories.Locations;

namespace ASP_Project.Services.LocationServices
{
    public class LocationService : ILocationService
    {
        public ILocations _ILocations;
        public LocationService (ILocations loc)
        {
            _ILocations = loc;
        }

        public async Task Create(Location location)
        {
            await _ILocations.CreateAsync(location);
            await _ILocations.SaveAsync();
        }

        public Task Delete(Location location)
        {
            _ILocations.Delete(location);
            return Task.CompletedTask;
        }
        public IAsyncEnumerable<Location> GetAsync()
        {
            return _ILocations.GetAsync();
        }

        public Guid GetLocation(string country, string city, string street)
        {
            return _ILocations.FindLocation(country, city, street);
        }
    }
}
