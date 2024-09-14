using LoginApi.Entities;
using LoginApi.Repositories;
using LoginApi.Repository;
using Microsoft.EntityFrameworkCore;

namespace LoginApi.Extention
{
    public static class LoginServices
    {
        public static IServiceCollection LoginService(this IServiceCollection services,IConfiguration configuration) 
        {
            services.AddDbContext<LoginContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("Default")));
            services.AddScoped<IValidateUserRepository, ValidateUser>();
            return services;
        }
    }
}
