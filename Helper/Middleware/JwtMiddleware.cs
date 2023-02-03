using ASP_Project.Helper.JwtUtils;
using ASP_Project.Services.UserServices;

namespace ASP_Project.Helper.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _nextRequestDelegate;
        public JwtMiddleware(RequestDelegate requestDelegate)
        {
            _nextRequestDelegate = requestDelegate;
        }
        public async Task Invoke(HttpContext httpContext, IUserServices userServices, IJwtUtils jwtUtils)
        {
            var token = httpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split("").Last();
            if (token == null)
                return;
            var userId = jwtUtils.ValidateToken(token);
            if(userId!= Guid.Empty)
            {
                httpContext.Items["User"] = userServices.GetUserById(userId);
            }
            await _nextRequestDelegate(httpContext);
        }
    }
}
