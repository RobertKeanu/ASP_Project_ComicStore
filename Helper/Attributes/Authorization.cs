using ASP_Project.Models;
using ASP_Project.Models.Base.Roles;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ASP_Project.Helper.Attributes
{
    public class Authorization : Attribute, IAuthorizationFilter
    {
        private readonly ICollection<Roles> _roles;   

        public Authorization(params Roles[] roles)
        {
            _roles = roles;
        }
        void IAuthorizationFilter.OnAuthorization(Microsoft.AspNetCore.Mvc.Filters.AuthorizationFilterContext context)
        {
            var unauthorizedStatusObject = new JsonResult(new {Message = "Unauthorized" }){ StatusCode = StatusCodes.Status401Unauthorized };

            if(_roles == null )
            {
                context.Result = unauthorizedStatusObject;
                return;
            }
            var user = (User?)context.HttpContext.Items["User"];
            if (user == null || _roles.Contains(user.Role))
            {
                context.Result = unauthorizedStatusObject;
            }
        }
    }
}
