

using PS.BioBoard.Application;
using PS.BioBoard.Infrastructure;
using PS.BioBoard.Infrastructure.Persistence.Initialization;
using PS.BioBoard.Web;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
       .AddPresentation()
       .AddApplication()
       .AddInfrastructure(builder.Configuration);

    builder.Services.AddRazorPages();
}

var app = builder.Build();
{

    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");

        app.UseHsts();
    }

    // Выполняем сидинг
    using (var scope = app.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        await ApplicationDbContextSeed.SeedAsync(services);
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthentication();
    app.UseAuthorization();  

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.MapRazorPages();

    app.Run();
}