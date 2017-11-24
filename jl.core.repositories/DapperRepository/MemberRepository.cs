using Dapper;
using JL.Core.Common;
using JL.Core.Models;
using JL.Core.Repositories;
using System;
using System.Data;
using System.Linq;
using JL.Core.Filters;
using System.Text;
using JL.Infrastructure;

namespace JL.Core.Repositories.DapperRepository
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

            return PageData<Member>.Create(pageReq.PageIndex, pageReq.PageSize, pages, total, data);
        }

        #region methods from t4

        public int Insert(Member model)
        {
            using (var connection = DbConnectionFactory.CreateConnection())
            {
                connection.Open();
                var id = connection.Query<int>(@"Insert into Member(NickName,RealName,Description,Phone,Weixin,QQ,Email,Address,JoinTime,Picture,Words,SortIndex,Status)
values (@NickName,@RealName,@Description,@Phone,@Weixin,@QQ,@Email,@Address,@JoinTime,@Picture,@Words,@SortIndex,@Status);SELECT LAST_INSERT_ID()",
                model).FirstOrDefault();

                connection.Close();
                return id;
            }
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

        public PageData<Member> MemberPage(PageReq<MemberFilter> pageReq)
        {
            var conn = DbConnectionFactory.CreateConnection();

            var dParas = new DynamicParameters();
            dParas.Add("@page", pageReq.PageIndex);
            dParas.Add("@pagesize", pageReq.PageSize);
            dParas.Add("@fields", "*");
            dParas.Add("@tablename", " member ");
            dParas.Add("@filter", BuildSqlFrom(pageReq.Data));
            dParas.Add("@orderby", pageReq.OrderBy);
            dParas.Add("@primarykey", "AutoId");
            dParas.Add("@total", direction: ParameterDirection.Output);

            var data = conn.Query<Member>("procPageQuery", param: dParas, commandType: CommandType.StoredProcedure);

            var total = dParas.Get<int>("@total");

            var pages = (int)Math.Ceiling((double)total / pageReq.PageSize);

            return PageData<Member>.Create(pageReq.PageIndex, pageReq.PageSize, pages, total, data);
        }

        private string BuildSqlFrom(MemberFilter filter)
        {
            if (filter != null)
            {
                StringBuilder sb = new StringBuilder();
                if (!string.IsNullOrEmpty(filter.NickName))
                {
                    sb.Append(" nickname like '%" + filter.NickName + "%' ");
                    sb.Append(" and ");
                }
                if (filter.JoinTimeFrom.HasValue)
                {
                    sb.Append(" jointime >= '" + filter.JoinTimeFrom.Value.ToString("yyyy-MM-dd") + "'");
                    sb.Append(" and ");
                }
                if (filter.JoinTimeTo.HasValue)
                {
                    sb.Append(" jointime <= '" + filter.JoinTimeTo.Value.ToString("yyyy-MM-dd") + "'");
                    sb.Append(" and ");
                }
                if(filter.Status>-1)
                {
                    sb.Append(" status = " + filter.Status);
                    sb.Append(" and ");
                }
                if (sb.Length > 0)
                    return sb.Remove(sb.Length - 4, 4).ToString();
            }

            return null;
        }
    }
}
