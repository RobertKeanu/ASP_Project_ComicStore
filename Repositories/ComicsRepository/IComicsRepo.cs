using ASP_Project.Models;
using ASP_Project.Repositories.GenericRepository;

namespace ASP_Project.Repositories.ComicsRepository
{
    public interface IComicsRepo : IGenericRepository<Comics>
    {
        Guid FindComic(string name, int price);

        Task<IEnumerable<Comics>> GetAllComicsFromComicStores(Guid storeId);
    }
}
