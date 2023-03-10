using ASP_Project.Models;
using ASP_Project.Models.DTOModels;
using ASP_Project.Repositories;

namespace ASP_Project.Services.UserServices
{
    public interface IUserServices
    {
        Task Create(User newUser);

        Task Delete(Guid id);

        Task<User?> GetUserById(Guid id);

        Task<bool> UpdateUser(DTOUser user, Guid id);


        Task<IEnumerable<User>> GetAllAdmins();


        DTOUserResponse? Authentificate (DTOUserRequest model);

        List<DTOUserRoles> GetAllUsersGroupByRole();

        IAsyncEnumerable<User> Get();
        //one more for authentification
    }
}
