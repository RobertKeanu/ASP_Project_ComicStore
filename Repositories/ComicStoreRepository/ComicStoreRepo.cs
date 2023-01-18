using ASP_Project.Data;
using ASP_Project.Models;
using ASP_Project.Repositories.GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace ASP_Project.Repositories.ComicStoreRepository
{
    public class ComicStoreRepo : GenericRepository<ComicStore>, IComicStoreRepo
    {
        public ComicStoreRepo(DataBaseContext context) : base(context) { }
    }
}
