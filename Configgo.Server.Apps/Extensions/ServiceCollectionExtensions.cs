using Configgo.Infra;
using Furion.DatabaseAccessor;

namespace Configgo.Server.Apps.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabaseContext(this IServiceCollection services)
        {
          return  services.AddDatabaseAccessor(options =>
            {
                var connectionStr = $@"Data Source=./Db/configgo.db";
                options.AddDbPool<ConfiggoContext>(DbProvider.Sqlite, connectionMetadata: connectionStr);
            }, "Configgo.Infra");
        }
    }
}
