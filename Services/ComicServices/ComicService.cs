using ASP_Project.Models;
using ASP_Project.Models.DTOModels;
using ASP_Project.Repositories;
using ASP_Project.Repositories.ComicsRepository;
using ASP_Project.Repositories.ComicStoreRepository;

namespace ASP_Project.Services.ComicServices
{
    public class ComicService : IComicService
    {
        public IUnitOfWork _IUnitOfWork;

        public ComicService(IUnitOfWork iUnitOfWork)
        {
            _IUnitOfWork = iUnitOfWork;
        }
        public async Task Create(Comics comic)
        {
            await _IUnitOfWork.ComicsRepo.CreateAsync(comic);
            await _IUnitOfWork.SaveAsync();
        }

        public async Task Delete(Guid id)
        {
            var comic = await _IUnitOfWork.ComicsRepo.FindByIdAsync(id);
            if(comic != null)
                _IUnitOfWork.ComicsRepo.Delete(comic);
            await _IUnitOfWork.SaveAsync();
        }

      /*  public Task<bool> DeleteAll(Comics comic)
        {
            _IComic.DeleteRange(comic);

        }*/

        public Guid FindComic(string name, int price)
        {
            return _IUnitOfWork.ComicsRepo.FindComic(name, price);
        }

        public IAsyncEnumerable<Comics> Get()
        {
            return _IUnitOfWork.ComicsRepo.GetAsync();
        }

        public Task<IEnumerable<Comics>> GetAllComicsFromComicStores(Guid storeId)
        {
            return _IUnitOfWork.ComicsRepo.GetAllComicsFromComicStores(storeId);
        }

        public async Task<bool> Update(DTOComics comic, Guid id)
        {
            var newComic = await _IUnitOfWork.ComicsRepo.FindByIdAsync(id);
            if (newComic == null)
                return false;
            newComic.ComicsName = comic.ComicsName;
            newComic.ComicsPrice = comic.ComicsPrice;
            newComic.ComicsDescription = comic.ComicsDescription;

            await _IUnitOfWork.SaveAsync();
            return true;
        }
    }
}
