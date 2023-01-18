using ASP_Project.Models;

namespace ASP_Project.Services.ComicStoreServices
{
    public interface IComicStoreServices
    {
        Task Create(ComicStore store);

        Task Delete(ComicStore store);

        IAsyncEnumerable<ComicStore> Get();

    }
}
