using Microsoft.EntityFrameworkCore;

namespace PandoraCaseTest.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("A FALLBACK CONNECTION STRING");
            }
        }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
