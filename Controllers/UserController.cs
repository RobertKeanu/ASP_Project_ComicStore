using ASP_Project.Models;
using ASP_Project.Models.Base.Roles;
using ASP_Project.Models.DTOModels;
using ASP_Project.Services.ComicServices;
using ASP_Project.Services.UserServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ASP_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUserServices _IUserServices;
        public UserController(IUserServices iUserServices)
        {
            _IUserServices = iUserServices;
        }
        [HttpPost("Create a new employee")]

        public async Task<ActionResult<DTOUserCreate>> CreateTheUser(DTOUserRequired user)
        {
            var userr = new User
            {
                FirstName = user.Name,
                Email = user.Email,
                RoleName = Roles.Employee,

            };
            await _IUserServices.Create(userr);
            return Ok(new DTOUserCreate
            {
                Id = userr.Id,
                Name = userr.FirstName,
                Email = userr.Email,
                RoleName = userr.RoleName,
            });
        }
        [HttpGet("Get All Users"), Authorize(Roles = "Admin,Employee")]
        public ActionResult<string> GetUsers()
        {
            var users = _IUserServices.Get();
            return Ok(users);
        }
        [HttpDelete ("Delete User by {id}") , Authorize(Roles = "Admin")]
        public async Task<ActionResult<string>> Delete(Guid id)
        {
            await _IUserServices.Delete(id);
            return Ok("deleted");
        }
        //next update
    }
}
