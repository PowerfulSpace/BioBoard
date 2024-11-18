using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PS.BioBoard.Application.Common.Interfaces.Persistence;
using PS.BioBoard.Infrastructure.Persistence;
using PS.BioBoard.Infrastructure.Persistence.Repositories;

namespace PS.BioBoard.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            services
                .AddPersistance(configuration);

            return services;
        }

        private static IServiceCollection AddPersistance(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<BioBoardDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IPersonRepository, PersonRepository>();

            return services;
        }

    }
}
