using ASP_Project.Repositories.ComicsRepository;
using ASP_Project.Repositories.ComicStoreRepository;
using ASP_Project.Repositories.Locations;
using ASP_Project.Repositories.UserRepository;
using ASP_Project.Repositories;
using Microsoft.Identity.Client;
using ASP_Project.Services.ComicServices;
using ASP_Project.Services.ComicStoreServices;
using ASP_Project.Services.LocationServices;
using ASP_Project.Services.UserServices;
using ASP_Project.Helper.JwtUtils;

namespace ASP_Project.Services
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddRepo(this IServiceCollection services)
        {
            services.AddTransient<IComicsRepo, ComicsRepo>();
            services.AddTransient<IComicStoreRepo, ComicStoreRepo>();
            services.AddTransient<ILocations, LocationRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<IComicService, ComicService>();
            services.AddTransient<IComicStoreServices, ComicStoreService>();
            services.AddTransient<ILocationService, LocationService>();
            services.AddTransient<IUserServices,UsersServices>();
            return services;
        }
        public static IServiceCollection AddUtils(this IServiceCollection services)
        {
            services.AddScoped<IJwtUtils, JwtUtils>();

            return services;
        }
    }
}
