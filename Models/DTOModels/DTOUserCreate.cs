using ASP_Project.Models.Base.Roles;

namespace ASP_Project.Models.DTOModels
{
    public class DTOUserCreate
    {
/*        public DTOUserCreate(Guid id, string userName, string name, string email, Roles roleName)
        {
            Id = id;
            UserName = userName;
            Name = name;
            Email = email;
            RoleName = roleName;
        }*/

        public Guid Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public Roles RoleName { get; set; }
    }
}
