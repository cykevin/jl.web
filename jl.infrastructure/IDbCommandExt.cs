using System;
using System.Data;
using System.Data.Common;

namespace JL.Infrastructure
{
    public static class IDbCommandExt
    {

        /// <summary>
        /// Uses this ConnectionHelper's Provider to create a DbParameter instance with the given parameter name and value.
        /// </summary>
        /// <param name="parameterName">The name of the parameter.</param>
        /// <param name="value">The value of the parameter.</param>
        /// <returns></returns>
        public static IDbDataParameter CreateParameter(this IDbCommand source, string parameterName, object value)
        {
            return source.CreateParameter(parameterName, value, null, null);
        }

        /// <summary>
        /// Uses this ConnectionHelper's Provider to create a DbParameter instance with the given parameter name and value.
        /// </summary>
        /// <param name="parameterName">The name of the parameter.</param>
        /// <param name="value">The value of the parameter.</param>
        /// <param name="dbType">The DB type.</param>
        /// <returns></returns>
        public static IDbDataParameter CreateParameter(this IDbCommand source, string parameterName, object value, DbType dbType)
        {
            return source.CreateParameter(parameterName, value, dbType, null);
        }

        /// <summary>
        /// Uses this ConnectionHelper's Provider to create a DbParameter instance with the given parameter name and value.
        /// </summary>
        /// <param name="parameterName">The name of the parameter.</param>
        /// <param name="value">The value of the parameter.</param>
        /// <param name="dbType">The DB type.</param>
        /// <param name="size">The size/length of the parameter.</param>
        /// <returns></returns>
        public static IDbDataParameter CreateParameter(this IDbCommand source, string parameterName, object value, DbType? dbType, int? size)
        {
            var param = source.CreateParameter();

            if (param == null)
            {
                throw new NullReferenceException("IDbCommand");
            }
            else
            {
                param.ParameterName = parameterName;
                param.Value = value;

                if (dbType.HasValue)
                    param.DbType = dbType.Value;

                if (size.HasValue)
                    param.Size = size.Value;

                return param;
            }
        }
    }
}
