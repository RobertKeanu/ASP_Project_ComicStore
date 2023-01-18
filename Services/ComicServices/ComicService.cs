using ASP_Project.Models;
using ASP_Project.Models.DTOModels;
using ASP_Project.Repositories.ComicsRepository;
using ASP_Project.Repositories.ComicStoreRepository;

namespace ASP_Project.Services.ComicServices
{
    public class ComicService : IComicService
    {
        public IComicsRepo _IComic;

        public ComicService(IComicsRepo com)
        {
            _IComic = com;
        }
        public async Task Create(Comics comic)
        {
            await _IComic.CreateAsync(comic);
            await _IComic.SaveAsync();
        }

        public async Task Delete(Guid id)
        {
            var comic = await _IComic.FindByIdAsync(id);
            if(comic != null)
                _IComic.Delete(comic);
            await _IComic.SaveAsync();
        }

      /*  public Task<bool> DeleteAll(Comics comic)
        {
            _IComic.DeleteRange(comic);

        }*/

        public Guid FindComic(string name, int price)
        {
            return _IComic.FindComic(name, price);
        }

        public IAsyncEnumerable<Comics> Get()
        {
            return _IComic.GetAsync();
        }

        public async Task<bool> Update(DTOComics comic, Guid id)
        {
            var newComic = await _IComic.FindByIdAsync(id);
            if (newComic == null)
                return false;
            newComic.ComicsName = comic.ComicsName;
            newComic.ComicsPrice = comic.ComicsPrice;
            newComic.ComicsDescription = comic.ComicsDescription;

            await _IComic.SaveAsync();
            return true;
        }
    }
}
