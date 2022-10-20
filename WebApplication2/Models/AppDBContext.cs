using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    public class AppDBContext: DbContext
    {
      public  AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<User> users { get; set; }
        public DbSet<Home> home { get; set; }

        
    }
}
