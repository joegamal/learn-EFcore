using learn.Entities;
using Microsoft.EntityFrameworkCore;

namespace learn
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Person { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
    }
}
