

using Microsoft.EntityFrameworkCore;
 
namespace Refresher.Models.dbContext
{
    public class RefDbContext : DbContext
    {

        public RefDbContext(DbContextOptions<RefDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;




        protected override void onModelCreating(ModelBuilder modelBuilder)
        {

      
            modelBuilder.Entity<DeviceType>().HasData(
                new DeviceType()
                {
                    Id = 1,
                    Name = "Laptop"
                },
                new DeviceType()
                {
                    Id = 2,
                    Name = "Tablet"
                }
             );

            modelBuilder.Entity<Device>(Device =>
            {
                Device.HasForeign
            })

            modelBuilder.Entity<Device>().HasData(
                new Device(){ 
                    Id = Guid.NewGuid().ToString(),
                    Name = "Device-3141",


                }
            )

        }

    }
}
