using Dapper;
using JL.Core.Common;
using JL.Core.Models;
using JL.Core.Repositories;
using System;
using System.Data;
using System.Linq;

namespace JL.Infrastructure.DapperRepository
{
    public class MemberRepository : IMemberRepository
    {
        public PageData<Member> MemberPage(PageReq pageReq)
        {
            var conn = DbConnectionFactory.CreateConnection();

            var dParas = new DynamicParameters();
            dParas.Add("@page", pageReq.PageIndex);
            dParas.Add("@pagesize", pageReq.PageSize);
            dParas.Add("@fields", "*");
            dParas.Add("@tablename", "Member");
            dParas.Add("@filter", "");
            dParas.Add("@orderby", pageReq.OrderBy);
            dParas.Add("@primarykey", "AutoId");
            dParas.Add("@total", direction: ParameterDirection.Output);

            var data = conn.Query<Member>("procPageQuery", param: dParas, commandType: CommandType.StoredProcedure);

            var total = dParas.Get<int>("@total");

            var pages = (int)Math.Ceiling((double)total / pageReq.PageSize);

            return PageData<Member>.Create(pageReq.PageIndex, pageReq.PageSize, pages, data);
        }

        #region methods from t4

        public void Insert(Member model)
        {
            var connection = DbConnectionFactory.CreateConnection();
            connection.Execute(@"Insert into Member(NickName,RealName,Description,Phone,Weixin,QQ,Email,Address,JoinTime,Picture,Words,SortIndex,Status)
values (@NickName,@RealName,@Description,@Phone,@Weixin,@QQ,@Email,@Address,@JoinTime,@Picture,@Words,@SortIndex,@Status)",
                model);
        }

        public Member GetById(int id)
        {
            var query = "select * from Member where AutoId=@id";

            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<Member>(query, new { id = id }).FirstOrDefault();

        }

        public void Update(Member model)
        {
            var sql = "update Member set NickName=@NickName,RealName=@RealName,Description=@Description,Phone=@Phone,Weixin=@Weixin,QQ=@QQ,Email=@Email,Address=@Address,JoinTime=@JoinTime,Picture=@Picture,Words=@Words,SortIndex=@SortIndex,Status=@Status where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(Member model)
        {
            var sql = "delete from Member where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(int id)
        {
            var sql = "delete from Member where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, new { AutoId = id });
        }

        #endregion
    }
}
