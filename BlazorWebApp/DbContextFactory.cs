using BlazorWebApp.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebApp
{
    public class DbContextFactory : IDesignTimeDbContextFactory<ClubDbContext>
    {
        public ClubDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ClubDbContext>();

            // Get the connection string from appsettings.json
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new ClubDbContext(optionsBuilder.Options);
        }
    }
}
