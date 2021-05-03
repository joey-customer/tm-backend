using Microsoft.EntityFrameworkCore;

namespace Its.TM.Backend.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {  
        }

        public DbSet<User> Users { get; set; }
    }
}