using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using ASP_Project.Models;
using ASP_Project.Models.DTOModels;
using ASP_Project.Repositories.ComicStoreRepository;
using ASP_Project.Services.ComicStoreServices;
using System.Data;

namespace ASP_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicStoresController : ControllerBase
    {
        public IComicStoreServices _IComicStoreService;
        public ComicStoresController(IComicStoreServices iComicStoreService)
        {
            _IComicStoreService = iComicStoreService;
        }
        [HttpPost("Create the store")]
        public async Task<ActionResult<string>> CreateComicStore(DTOComicStore store)
        {
            var storecreate = new ComicStore
            {
                ComicStoreName = store.ComicStoreName,
            };
            await _IComicStoreService.Create(storecreate); 
            return Ok("Created the store");
        }
        [HttpGet("Get Store")]
        public ActionResult<string> GetStore()
        {
            var loc = _IComicStoreService.Get();
            return Ok(loc);
        }

        [HttpDelete("Delete Store")]
        public ActionResult<string> DeleteStore(ComicStore loc)
        {
            var location = _IComicStoreService.Delete(loc);
            return Ok("deleted the store");
        }
    }
}
