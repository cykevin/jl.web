using Dapper;
using JL.Core.Models;
using JL.Core.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;
using JL.Infrastructure;

namespace JL.Core.Repositories.DapperRepository
{
    public partial class SettingRepository : ISettingRepository
    {
        public int Insert(Setting model)
        {
            var connection = DbConnectionFactory.CreateConnection();
            var id = connection.Query<int>(@"Insert into setting(`Key`,`Value`)
values (@Key,@Value);SELECT LAST_INSERT_ID()",
                model).FirstOrDefault();
            return id;
        }

        public Setting GetById(int id)
        {
            var query = "select * from setting where AutoId=@id";

            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<Setting>(query, new { id = id }).FirstOrDefault();

        }

        public void Update(Setting model)
        {
            var sql = "update setting set Key=@Key,Value=@Value where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(Setting model)
        {
            var sql = "delete from setting where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(int id)
        {
            var sql = "delete from setting where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, new { AutoId = id });
        }

        public IEnumerable<Setting> GetList()
        {
            var sql = "select * from setting";
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                return conn.Query<Setting>(sql);
            }
        }
    }
}
