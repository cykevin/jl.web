using System;
using System.Configuration;
using System.Configuration.Provider;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace JL.Infrastructure
{
    public class DbConnectionFactory
    {
        private static readonly string connStringName = "MySqlConnection";

        public static IDbConnection CreateConnection()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[connStringName];

            var dbProvFactory = DbProviderFactories.GetFactory(settings.ProviderName);
            var connection = dbProvFactory.CreateConnection();
            if (connection == null)
            {
                throw new System.Exception("创建数据库连接失败");
            }
            if (connection != null)
            {
                connection.ConnectionString = settings.ConnectionString;
            }
            
            return connection;
        }

    }
}
