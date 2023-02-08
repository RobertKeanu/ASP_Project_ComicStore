using ASP_Project.Data;
using ASP_Project.Models;
using ASP_Project.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.Metrics;
using System.IO;

namespace ASP_Project.Repositories.ComicsRepository
{
    public class ComicsRepo : GenericRepository<Comics>, IComicsRepo
    {
        private readonly DbSet<Comics> _dbSet;
        private readonly DbSet<ComicStore> _dbSetStore;
        public ComicsRepo(DataBaseContext context) : base(context) {
            _dbSet = _DataBaseContext.Comics;
            _dbSetStore = _DataBaseContext.ComicStore;
        }

        public Guid FindComic(string name, int price)
        {
            var comic = _table.FirstOrDefault(o => o.ComicsName == name && o.ComicsPrice == price);
            if (comic == null)
                return Guid.Empty;
            return comic.Id;
        }

        public async Task<IEnumerable<Comics>> GetAllComicsFromComicStores(Guid storeId)
        {
            return (IEnumerable<Comics>)await (from comics in _dbSet.AsNoTracking()
                          where comics.ComicStoreID == storeId
                          join tt in _dbSetStore
                            on comics.ComicStoreID equals tt.ComicStoreID
                            group comics by comics.ComicStoreID).ToListAsync();
        }
    }
}
