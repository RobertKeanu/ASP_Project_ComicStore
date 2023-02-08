using ASP_Project.Helper.Attributes;
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

        public async Task<ActionResult<DTOUserCreate>> CreateTheUser(DTOUserRequest user)
        {
            var userr = new User
            {
                FirstName = user.Name,
                Email = user.Email,
                Role = Roles.Employee,
                PhoneNumber = user.PhoneNumber,
                Preferences = user.Preferences,

            };
            await _IUserServices.Create(userr);
            return Ok(new DTOUserCreate
            {
                Id = userr.Id,
                Name = userr.FirstName,
                Email = userr.Email,
                RoleName = userr.Role,
                PhoneNumber = userr.PhoneNumber,
                Preferences = userr.Preferences,
            });
        }
        [HttpPost("Create a new admin")]
        public async Task<ActionResult<DTOUserCreate>> CreateTheAdmin(DTOUserRequest user)
        {
            var userr = new User
            {
                FirstName = user.Name,
                Email = user.Email,
                Role = Roles.Admin,
                PhoneNumber = user.PhoneNumber,
                Preferences = user.Preferences,

            };
            await _IUserServices.Create(userr);
            return Ok(new DTOUserCreate
            {
                Id = userr.Id,
                Name = userr.FirstName,
                Email = userr.Email,
                RoleName = userr.Role,
                PhoneNumber = userr.PhoneNumber,
                Preferences = userr.Preferences,
            });
        }

        [HttpPost("Create a new User")]
        public async Task<ActionResult<DTOUserCreate>> CreateTheBasicUser(DTOUserRequest user)
        {
            var userr = new User
            {
                FirstName = user.Name,
                Email = user.Email,
                Role = Roles.User,
                PhoneNumber = user.PhoneNumber,
                Preferences = user.Preferences,

            };
            await _IUserServices.Create(userr);
            return Ok(new DTOUserCreate
            {
                Id = userr.Id,
                Name = userr.FirstName,
                Email = userr.Email,
                RoleName = userr.Role,
                PhoneNumber = userr.PhoneNumber,
                Preferences = userr.Preferences,
            });
        }
        [HttpGet("Get All Users") ,Authorization(Roles.Admin)]
        public ActionResult<string> GetUsers()
        {
            var users = _IUserServices.Get();
            return Ok(users);
        }
        [HttpDelete ("Delete User by {id}") ,Authorization(Roles.Admin)]
        public async Task<ActionResult<string>> Delete(Guid id)
        {
            await _IUserServices.Delete(id);
            return Ok("deleted");
        }
        [HttpPut("update with the {id}") , Authorization(Roles.Admin)]
        public async Task<ActionResult<string>> Updating (DTOUser user, Guid id)
        {
            var update = await _IUserServices.UpdateUser(user, id);

            if (update != false)
                return Ok("Good Update!");
            else return StatusCode(555);

        }
        [HttpGet("Here are all admins with rented comics")]
        public Task<IEnumerable<User>> GetAdminsWithComicsRented()
        {
            var ddd = _IUserServices.GetAllAdmins();
            return ddd;
        }

        [HttpGet("Here are all users by roles")]
        public List<DTOUserRoles> GetAllUsersGroupByRole()
        {
            var ww = _IUserServices.GetAllUsersGroupByRole();
            return ww;
        }
        //next update
    }
}
