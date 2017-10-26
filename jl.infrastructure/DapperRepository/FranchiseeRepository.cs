using Dapper;
using JL.Core.Common;
using JL.Core.Models;
using JL.Core.Repositories;
using System;
using System.Linq;

namespace JL.Infrastructure.DapperRepository
{
    public class FranchiseeRepository : IFranchiseeRepository
    {
        public PageData<Franchisee> FranchiseePage(PageReq pageReq)
        {
            throw new NotImplementedException();
        }        

        #region methods from t4

        public void Add(Franchisee model)
        {
            var connection = DbConnectionFactory.CreateConnection();
            connection.Execute(@"Insert into Franchisee(Name,Email,Weixin,Phone,Address,Remark,ApplyTime,ProcessTime,Status)
values (@Name,@Email,@Weixin,@Phone,@Address,@Remark,@ApplyTime,@ProcessTime,@Status)",
                model);
        }

        public Franchisee GetById(int id)
        {
            var query = "select * from Franchisee where AutoId=@id";

            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<Franchisee>(query, new { id = id }).FirstOrDefault();

        }

        public void Update(Franchisee model)
        {
            var sql = "update Franchisee set Name=@Name,Email=@Email,Weixin=@Weixin,Phone=@Phone,Address=@Address,Remark=@Remark,ApplyTime=@ApplyTime,ProcessTime=@ProcessTime,Status=@Status where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(Franchisee model)
        {
            var sql = "delete from Franchisee where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(int id)
        {
            var sql = "delete from Franchisee where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, new { AutoId = id });
        }

        #endregion
    }
}
