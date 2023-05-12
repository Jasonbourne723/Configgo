using Configgo.Model;
using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace Configgo.Infra
{
    public class ConfiggoContext : AppDbContext<ConfiggoContext>
    {
        public ConfiggoContext(DbContextOptions<ConfiggoContext> options) : base(options)
        {
        }

        public DbSet<VHost> vHosts { get; set; }

        public DbSet<App> apps { get; set; }

        public DbSet<Env> envs { get; set; }
    }
}