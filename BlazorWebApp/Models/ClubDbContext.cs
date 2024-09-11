using Microsoft.EntityFrameworkCore;

namespace BlazorWebApp.Models
{

    public class ClubDbContext : DbContext
    {
        public ClubDbContext(DbContextOptions<ClubDbContext> options) : base(options)
        {
        }

        public DbSet<Club> Clubs { get; set; }
    }
}
