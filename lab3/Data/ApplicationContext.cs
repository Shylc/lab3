using Microsoft.EntityFrameworkCore;

using lab3.Infrastructure.Models;

namespace lab3.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Team> Teams { get; set; }
    }
}
