using ASP_Project.Models;

namespace ASP_Project.Helper.JwtUtils
{
    public interface IJwtUtils
    {
        public string GenerateJwtToken(User user);

        public Guid ValidateToken(string token);
    }
}
