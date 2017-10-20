using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jl.infrastructure
{
    public class DbConnectionHelper
    {
        private string connStringName;
        
        public IDbConnection CreateConnection()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[this.connStringName];

            var dbProvFactory = DbProviderFactories.GetFactory(settings.ProviderName);
            var connection = dbProvFactory.CreateConnection();

            return connection;
        }
    }
}
