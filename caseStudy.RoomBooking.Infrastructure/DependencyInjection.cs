using caseStudy.RoomBooking.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace caseStudy.RoomBooking.Infrastructure
{

    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            string dbType = configuration["Database:Type"] ?? string.Empty;

            services.AddDbContext<EFContext>(options =>
            {
                switch (dbType)
                {
                    case "PostgreSQL":
                        options.UseNpgsql(configuration.GetConnectionString("PostgresConnection"));
                        break;

                    // case "InMemory":
                    //     options.UseInMemoryDatabase("InMemoryDbForTesting");
                    //     break; 

                    default: throw new Exception("Invalid database type");
                }

            });

            // services.AddScoped<IApplicationDbContext>(sp => sp.GetRequiredService<EFContext>());

            return services;
        }
    }

}