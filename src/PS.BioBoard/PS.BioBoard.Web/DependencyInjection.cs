namespace PS.BioBoard.Web
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AdminPolicy", policy =>
                    policy.RequireRole("Administrator"));


                options.AddPolicy("ManagerPolicy", policy =>
                {
                    policy.RequireAssertion(context =>
                        context.User.IsInRole("Administrator") 
                        || context.User.IsInRole("Manager"));
                });


                options.AddPolicy("UserPolicy", policy =>
                {
                    policy.RequireAssertion(context =>
                        context.User.IsInRole("Administrator") 
                        || context.User.IsInRole("Manager") 
                        || context.User.IsInRole("User"));
                });

            });

            return services;
        }
    }
}
