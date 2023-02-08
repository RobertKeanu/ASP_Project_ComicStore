using ASP_Project.Data;
using ASP_Project.Models;
using ASP_Project.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace ASP_Project.Repositories.ComicStoreRepository
{
    public class ComicStoreRepo : GenericRepository<ComicStore>, IComicStoreRepo
    {
        public ComicStoreRepo(DataBaseContext context) : base(context) { }

        public Guid FindById(Guid id)
        {
            var comicstore = _table.FirstOrDefault(t => t.Id == id);
            if (comicstore != null)
            {
                return comicstore.Id;
            }
            else
                return Guid.Empty;
        }
    }
}
