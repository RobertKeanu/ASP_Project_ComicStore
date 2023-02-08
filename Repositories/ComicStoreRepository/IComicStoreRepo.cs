using ASP_Project.Models;
using ASP_Project.Repositories.GenericRepository;

namespace ASP_Project.Repositories.ComicStoreRepository
{
    public interface IComicStoreRepo : IGenericRepository<ComicStore> 
    {
        public Guid FindById(Guid id);
    }
}
