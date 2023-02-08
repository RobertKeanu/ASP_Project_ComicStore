using ASP_Project.Models;
using ASP_Project.Models.DTOModels;

namespace ASP_Project.Services.ComicServices
{
    public interface IComicService
    {
        Task Create(Comics comic);

        Task Delete(Guid id);

/*        Task<bool> DeleteAll();*/

        Task<bool> Update(DTOComics comic, Guid id);
        IAsyncEnumerable<Comics> Get();

        Guid FindComic(string name, int price);

        public Task<IEnumerable<Comics>> GetAllComicsFromComicStores(Guid storeId);
    }
}
