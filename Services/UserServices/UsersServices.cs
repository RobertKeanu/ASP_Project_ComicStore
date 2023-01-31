using ASP_Project.Models;
using ASP_Project.Models.DTOModels;
using ASP_Project.Repositories;

namespace ASP_Project.Services.UserServices
{
    public class UsersServices : IUserServices
    {
        public IUnitOfWork _IUnitOfWork;

        public UsersServices(IUnitOfWork iUnitOfWork)
        {
            _IUnitOfWork = iUnitOfWork;
        }

        Task IUserServices.Create(User newUser)
        {
            throw new NotImplementedException();
        }

        Task IUserServices.Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUserServices.DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }

        IAsyncEnumerable<User> IUserServices.Get()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<User>> IUserServices.GetAllAdmins()
        {
            throw new NotImplementedException();
        }

        Task<User> IUserServices.GetUserById(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUserServices.UpdateUser(DTOUser user, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
