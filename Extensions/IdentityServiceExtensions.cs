using BeautyNails.Data;
using BeautyNails.Models;

namespace BeautyNails.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config) 
        {
            services.AddIdentityCore<AppUser>(opt =>
            {

            })
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddAuthentication();
            return services;
        }
    }
}
