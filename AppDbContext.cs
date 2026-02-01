using Microsoft.EntityFrameworkCore;
using CarbonTrackerMVC.Models;

namespace CarbonTrackerMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Meal> Meals { get; set; }
    }
}
