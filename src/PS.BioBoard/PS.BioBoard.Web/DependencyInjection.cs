using FluentValidation.AspNetCore;

namespace PS.BioBoard.Web
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddFluentValidationAutoValidation();
            services.AddFluentValidationClientsideAdapters();

            return services;
        }
    }
}
