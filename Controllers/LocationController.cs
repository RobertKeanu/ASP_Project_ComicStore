using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using ASP_Project.Models;
using ASP_Project.Models.DTOModels;
using ASP_Project.Repositories.Locations;
using ASP_Project.Services.LocationServices;
using System.Data;

namespace ASP_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        public ILocationService _ILocationService;
        public LocationController(ILocationService iLocationService)
        {
            _ILocationService = iLocationService;
        }
        [HttpPost("Create the location")]
        public async Task<ActionResult<string>> CreateLocation (DTOLocation loc)
        {
            var locationCreate = new Location
            {
                Country = loc.Country,
                Region = loc.Region,
                City = loc.City,
                Street = loc.Street,
                NumberStore = loc.NumberStore,
            };
            await _ILocationService.Create(locationCreate); 

            return Ok("Created the location");
        }
        [HttpGet("Get Location")]
        public ActionResult<string> GetLocation()
        {
            var loc = _ILocationService.GetAsync();
            return Ok(loc);
        }

        [HttpDelete("Delete location")]
        public ActionResult<string> DeleteLocation(Location loc)
        {
            var location = _ILocationService.Delete(loc);
            return Ok("deleted the location");
        }

    }
}
