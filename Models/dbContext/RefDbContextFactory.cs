using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Pomelo.EntityFrameworkCore.MySql;
using DotNetEnv;

namespace Refresher.Models.dbContext
{
    public class RefDbContextFactory : IDesignTimeDbContextFactory<RefDbContext>
    {   
        public RefDbContext CreateDbContext(string[] args){

            var optionsBuilder = new DbContextOptionsBuilder<RefDbContext>();

            Env.Load();

            string server = Environment.GetEnvironmentVariable("SQL_SERVER_HOST")!;
            string user = Environment.GetEnvironmentVariable("SQL_USER")!;
            string pass = Environment.GetEnvironmentVariable("SQL_PASS")!;
            string db = Environment.GetEnvironmentVariable("SQL_DB")!;

            optionsBuilder.UseMySql(
                $"Server={server};Port=3306;Database={db};User={user};Password={pass};",
                ServerVersion.AutoDetect($"Server={server};Port=3306;Database={db};User={user};Password={pass};")
            );


            return new RefDbContext(optionsBuilder.Options);

        }

       
    }
}
