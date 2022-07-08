using fcapi.EFModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace fcapi
{
    public class MyDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MyDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Form> Form { get; set; }
        public DbSet<FormEvent> FormEvent { get; set; }
        public DbSet<signature> signature { get; set; }
        public DbSet<ActingSetting> ActingSetting { get; set; }
        public DbSet<ActingEmployeeMap> ActingEmployeeMap { get; set; }
    }
}
