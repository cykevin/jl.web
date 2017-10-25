using System.Configuration;
using System.Configuration.Provider;
using System.Data;
using System.Data.Common;

namespace JL.Infrastructure
{
    public class DbConnectionFactory
    {
        private static readonly string connStringName = "DefaultConnection";


        public static IDbConnection CreateConnection()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[connStringName];

            var dbProvFactory = DbProviderFactories.GetFactory(settings.ProviderName);
            var connection = dbProvFactory.CreateConnection();

            return connection;
        }
    }
}
