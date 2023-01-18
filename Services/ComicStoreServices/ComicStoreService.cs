using ASP_Project.Models;
using ASP_Project.Repositories;
using ASP_Project.Repositories.ComicStoreRepository;


namespace ASP_Project.Services.ComicStoreServices
{
    public class ComicStoreService : IComicStoreServices
    {
        public IComicStoreRepo _IComicStore;

        public ComicStoreService(IComicStoreRepo loc)
        {
            _IComicStore = loc;
        }
        public async Task Create(ComicStore store)
        {
            await _IComicStore.CreateAsync(store);
            await _IComicStore.SaveAsync();
        }

        public Task Delete(ComicStore store)
        {
            _IComicStore.Delete(store);
            return Task.CompletedTask;
        }

        public IAsyncEnumerable<ComicStore> Get()
        {
            return _IComicStore.GetAsync();
        }
    }
}
