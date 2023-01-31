using ASP_Project.Repositories.ComicsRepository;
using ASP_Project.Repositories.ComicStoreRepository;
using ASP_Project.Repositories.Locations;
using ASP_Project.Repositories.UserRepository;
using ASP_Project.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Microsoft.Data.SqlClient;

namespace ASP_Project.Repositories
{
    public interface IUnitOfWork
    {
        IComicsRepo ComicsRepo { get; }
        IComicStoreRepo ComicStore { get; }

        ILocations LocationRepository { get; }

        IUserRepository UserRepository { get; }

        Task <bool> SaveAsync();
    }
    public class UnitOfWork : IUnitOfWork
    {
        public IComicsRepo ComicsRepo { get; set; }
        public IComicStoreRepo ComicStore { get; set; }

        public ILocations LocationRepository { get; set; }

        public IUserRepository UserRepository { get; set; }

        private DataBaseContext _DBContext { get; set; }

        public UnitOfWork(IComicsRepo comicsRepo, IComicStoreRepo comicStore, ILocations locationRepository, IUserRepository userRepository, DataBaseContext dataBaseContext)
        {
            ComicsRepo = comicsRepo;
            ComicStore = comicStore;
            LocationRepository = locationRepository;
            UserRepository = userRepository;
            _DBContext = dataBaseContext;
        }
        public async Task<bool> SaveAsync()
        {
            try
            {
                return await _DBContext.SaveChangesAsync() > 0;
            }
            catch (SqlException s)
            {
                Console.WriteLine("Doesn't work");
                Console.WriteLine(s);
            }
            return false;
        }
    }

}
