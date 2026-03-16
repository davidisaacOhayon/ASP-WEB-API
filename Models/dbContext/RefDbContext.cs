

using Microsoft.EntityFrameworkCore;
 
namespace Refresher.Models.dbContext
{
    public class RefDbContext : DbContext
    {

        public RefDbContext(DbContextOptions<RefDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
    }
}
