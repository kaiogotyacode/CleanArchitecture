using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Persistence.Context;
using CleanArchitecture.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Persistence
{
    public class ServiceExtensions
    {
        public static void ConfigurePersistenceApp(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DatabaseContext>(db => db.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();  
            services.AddScoped<IUserRepository, UserRepository>();  
        }
    }
}
