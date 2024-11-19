using Microsoft.Extensions.DependencyInjection;
using PS.BioBoard.Application.Services.Persons;

namespace PS.BioBoard.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();
            return services;
        }
    }
}
