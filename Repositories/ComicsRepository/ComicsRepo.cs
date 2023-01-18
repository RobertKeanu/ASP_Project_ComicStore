using ASP_Project.Data;
using ASP_Project.Models;
using ASP_Project.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System.IO;

namespace ASP_Project.Repositories.ComicsRepository
{
    public class ComicsRepo : GenericRepository<Comics>, IComicsRepo
    {
        public ComicsRepo(DataBaseContext context) : base(context) { }

        public Guid FindComic(string name, int price)
        {
            var comic = _table.FirstOrDefault(o => o.ComicsName == name && o.ComicsPrice == price);
            if (comic == null)
                return Guid.Empty;
            return comic.Id;
        }
    }
}
