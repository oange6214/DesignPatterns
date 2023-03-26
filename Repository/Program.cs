
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Database;
using Repository.Repos.Implements;
using Repository.Repos.Interfaces;
using Repository.Services.Implements;
using Repository.Services.Interfaces;

void ConfigureServices(IServiceCollection services)
{
    IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

    var connection = configuration.GetConnectionString("DefaultConnection");

    // DI Register
    services.AddScoped<IRecipeService, RecipeService>();
    services.AddScoped<IRecipeRepository, RecipeRepository>();
    services.AddScoped<IDatabaseHelper>(options => new DatabaseHelper(connection));

}
