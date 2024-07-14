using Microsoft.EntityFrameworkCore;
using ProjectManageAPI.Models;

namespace ProjectManageAPI.Data
{
    public class PMDbContext : DbContext
    {
        public PMDbContext(DbContextOptions<PMDbContext> options) : base(options)
        {
            //Database.SetInitializer<PMDbContext>(new CreateDatabaseIfNotExists<PMDbContext>());

        }

        public DbSet<User> Users { get; set; }
    }
}