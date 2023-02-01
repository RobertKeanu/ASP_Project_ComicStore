using ASP_Project.Models;
using ASP_Project.Models.DTOModels;
using ASP_Project.Repositories;
using Microsoft.IdentityModel.Tokens;

namespace ASP_Project.Services.UserServices
{
    public class UsersServices : IUserServices
    {
        public IUnitOfWork _IUnitOfWork;

        public UsersServices(IUnitOfWork iUnitOfWork)
        {
            _IUnitOfWork = iUnitOfWork;
        }

        public async Task Create(User newUser)
        {
            await _IUnitOfWork.UserRepository.CreateAsync(newUser);
            await _IUnitOfWork.SaveAsync();
        }

        public async Task Delete(Guid id)
        {
            var userr = await _IUnitOfWork.UserRepository.FindByIdAsync(id);
            if(userr != null)
             _IUnitOfWork.UserRepository.Delete(userr);
            await _IUnitOfWork.SaveAsync();
        }

        public IAsyncEnumerable<User> Get()
        {
            return _IUnitOfWork.UserRepository.GetAsync();
        }

        public Task<IEnumerable<User>> GetAllAdmins()
        {
            return _IUnitOfWork.UserRepository.GetAdminsWithComicsRented();
        }

        public async Task<User?> GetUserById(Guid id)
        {

            return await _IUnitOfWork.UserRepository.FindByIdAsync(id);
        }

        async Task<bool> IUserServices.UpdateUser(DTOUser user, Guid id)
        {
            var myus = await _IUnitOfWork.UserRepository.FindByIdAsync(id);
            if (myus == null)
                return false;
            myus.DateOfBirth = user.DateOfBirth;
            myus.FirstName = user.FirstName;
            myus.LastName = user.LastName;
            myus.PhoneNumber = user.PhoneNumber;

            await _IUnitOfWork.SaveAsync();

            return true;
        }
    }
}
