using ASP_Project.Models;
using ASP_Project.Repositories;
using ASP_Project.Repositories.Locations;

namespace ASP_Project.Services.LocationServices
{
    public class LocationService : ILocationService
    {
        public IUnitOfWork _IUnitOfWork;

        public LocationService(IUnitOfWork iUnitOfWork)
        {
            _IUnitOfWork = iUnitOfWork;
        }

        public async Task Create(Location location)
        {
            await _IUnitOfWork.LocationRepository.CreateAsync(location);
            await _IUnitOfWork.SaveAsync();
        }

        public Task Delete(Location location)
        {
            _IUnitOfWork.LocationRepository.Delete(location);
            _IUnitOfWork.SaveAsync();
            return Task.CompletedTask;
        }
        public IAsyncEnumerable<Location> GetAsync()
        {
            return _IUnitOfWork.LocationRepository.GetAsync();
        }

        public Guid GetLocation(string country, string city, string street)
        {
            return _IUnitOfWork.LocationRepository.FindLocation(country, city, street);
        }
    }
}
