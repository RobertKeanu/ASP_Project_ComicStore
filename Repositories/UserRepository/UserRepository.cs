using ASP_Project.Data;
using ASP_Project.Models;
using ASP_Project.Models.Base.Roles;
using ASP_Project.Repositories.GenericRepository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using ASP_Project.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ASP_Project.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DataBaseContext context) : base(context)
        {
        }

        public IEnumerable<User> FindAllUsers()
        {
            var empls = _table.ToList();
            return empls.Where(o => o.Role == Roles.User);
        }

        public User? FindByEmail(string email)
        {
            if (email != null)
            {
                return _table.FirstOrDefault(o => o.Email == email);
            }
            else return null;
        }

        public async Task<IEnumerable<User>> GetAdminsWithComicsRented()
        {
            return await _table.Where(o => o.Role == Roles.Admin).Include(u => u.Comic).ToListAsync();
        }
    }
}
