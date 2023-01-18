using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using ASP_Project.Models;
using ASP_Project.Models.DTOModels;
using ASP_Project.Repositories.ComicsRepository;
using ASP_Project.Services.ComicServices;
using System.Data;
namespace ASP_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicsController : ControllerBase
    {
        public IComicService _IComicsService;
        public ComicsController(IComicService iComicsService)
        {
            _IComicsService = iComicsService;
        }
        [HttpPost("Create the comic book")]
        public async Task<ActionResult<string>> CreateComic(DTOComics comic)
        {
            var comiccreate = new Comics
            {
                ComicsName = comic.ComicsName,
                ComicsDescription = comic.ComicsDescription,
                ComicsPrice = comic.ComicsPrice,
            };
            await _IComicsService.Create(comiccreate);
            return Ok("Created the comic");
        }
        [HttpDelete("Delete Store with /{id}")]
        public async Task<ActionResult<string>> DeleteComic(Guid id)
        {
            await _IComicsService.Delete(id);
            return Ok("Comic {id} deleted");
        }
        [HttpGet("Get Comic")]
        public ActionResult<string> GetComic()
        {
            var comics = _IComicsService.Get();
            return Ok(comics);
        }
        [HttpPut("Update the comic /{id}")]
        public async Task<ActionResult<string>> UpdateComic(DTOComics comic, Guid id)
        {
            var comicCheck = await _IComicsService.Update(comic, id);
            if (comicCheck != false)
                return Ok("Updated the comic");
            else return BadRequest(111);
        }
    }
}
