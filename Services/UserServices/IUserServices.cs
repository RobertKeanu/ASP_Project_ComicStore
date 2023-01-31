using ASP_Project.Models;
using ASP_Project.Models.DTOModels;
using ASP_Project.Repositories;

namespace ASP_Project.Services.UserServices
{
    public interface IUserServices
    {
        Task Create(User newUser);

        Task Delete(Guid id);

        Task<User> GetUserById(Guid id);

        Task<bool> UpdateUser(DTOUser user, Guid id);

        Task<bool> DeleteUser(Guid id);

        Task<IEnumerable<User>> GetAllAdmins();

        IAsyncEnumerable<User> Get();
        //one more for authentification
    }
}
