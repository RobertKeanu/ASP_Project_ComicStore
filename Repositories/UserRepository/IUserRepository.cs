using ASP_Project.Models;
using ASP_Project.Repositories.GenericRepository;

namespace ASP_Project.Repositories.UserRepository
{
    public interface IUserRepository : IGenericRepository <User>
    {
        User? FindByEmail(string email);
        IEnumerable<User> FindAllUsers();

        Task<IEnumerable<User>> GetAdminsWithComicsRented();
    }
}
