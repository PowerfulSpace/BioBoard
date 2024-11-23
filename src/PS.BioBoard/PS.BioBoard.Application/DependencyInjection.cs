using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using PS.BioBoard.Application.Services.Persons;
using PS.BioBoard.Application.Validators;

namespace PS.BioBoard.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IPersonService, PersonService>();

            services.AddValidatorsFromAssemblyContaining<PersonValidator>();

            services.AddFluentValidationAutoValidation(options =>
            {
                options.DisableDataAnnotationsValidation = true;
            });

            return services;
        }
    }
}