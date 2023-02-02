using ASP_Project.Models;
using ASP_Project.Repositories;
using ASP_Project.Repositories.ComicStoreRepository;


namespace ASP_Project.Services.ComicStoreServices
{
    public class ComicStoreService : IComicStoreServices
    {
        public IUnitOfWork _IUnitOfWork;

        public ComicStoreService(IUnitOfWork iUnitOfWork)
        {
            _IUnitOfWork = iUnitOfWork;
        }
        public async Task Create(ComicStore store)
        {
            await _IUnitOfWork.ComicStore.CreateAsync(store);
            await _IUnitOfWork.SaveAsync();
        }

        public Task Delete(ComicStore store)
        {
            _IUnitOfWork.ComicStore.Delete(store);
            return Task.CompletedTask;
        }

        public IAsyncEnumerable<ComicStore> Get()
        {
            return _IUnitOfWork.ComicStore.GetAsync();
        }
    }
}
