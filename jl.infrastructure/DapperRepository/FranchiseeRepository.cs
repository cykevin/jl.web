using Dapper;
using JL.Core.Common;
using JL.Core.Models;
using JL.Core.Repositories;
using System;
using System.Data;
using System.Linq;

namespace JL.Infrastructure.DapperRepository
{
    public class FranchiseeRepository : IFranchiseeRepository
    {
        public PageData<Franchisee> FranchiseePage(PageReq pageReq)
        {
            var conn = DbConnectionFactory.CreateConnection();

            var dParas = new DynamicParameters();
            dParas.Add("@page", pageReq.PageIndex);
            dParas.Add("@pagesize", pageReq.PageSize);
            dParas.Add("@fields", "*");
            dParas.Add("@tablename", "Franchisee");
            dParas.Add("@filter", "");
            dParas.Add("@orderby", pageReq.OrderBy);
            dParas.Add("@primarykey", "AutoId");
            dParas.Add("@total", direction: ParameterDirection.Output);

            var data = conn.Query<Franchisee>("procPageQuery", param: dParas, commandType: CommandType.StoredProcedure);

            var total = dParas.Get<int>("@total");

            var pages = (int)Math.Ceiling((double)total / pageReq.PageSize);

            return PageData<Franchisee>.Create(pageReq.PageIndex, pageReq.PageSize, pages, data);
        }

        #region methods from t4

        public void Insert(Franchisee model)
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
