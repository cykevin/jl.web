using Dapper;
using JL.Core.Common;
using JL.Core.Filters;
using JL.Core.Models;
using JL.Core.Repositories;
using JL.Infrastructure;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace JL.Core.Repositories.DapperRepository
{
    public class UserRepository : IUserRepository
    {
        public UserProfile GetById(int id)
        {
            var query = "select * from jl_user where userid=@id";
                
            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<UserProfile>(query, new { id = id }).FirstOrDefault();
        }

        public UserProfile GetByUsername(string username)
        {
            var query = "select * from jl_user where username=@username";

            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<UserProfile>(query, new { username = username }).FirstOrDefault();
        }        
               

        #region methods from t4

        public int Insert(UserProfile model)
        {
            var connection = DbConnectionFactory.CreateConnection();
            var id = connection.Query<int>(@"Insert into Users(UserName,Cellphone,IsCellphoneConfirmed,Email,IsEmailConfirmed,RealName,NickName,Telephone,Birthday,Gender,QQ,Address,AddTime,RegUrl)
values (@UserName,@Cellphone,@IsCellphoneConfirmed,@Email,@IsEmailConfirmed,@RealName,@NickName,@Telephone,@Birthday,@Gender,@QQ,@Address,@AddTime,@RegUrl);SELECT LAST_INSERT_ID()",
                model).FirstOrDefault();
            return id;
        }

        public UserProfile GetModel(int id)
        {
            var query = "select * from jl_user where UserId=id";

            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<UserProfile>(query, new { UserId = id }).FirstOrDefault();

        }

        public void Update(UserProfile model)
        {
            var sql = "update jl_user set UserName=@UserName,Cellphone=@Cellphone,IsCellphoneConfirmed=@IsCellphoneConfirmed,Email=@Email,IsEmailConfirmed=@IsEmailConfirmed,RealName=@RealName,NickName=@NickName,Telephone=@Telephone,Birthday=@Birthday,Gender=@Gender,QQ=@QQ,Address=@Address,AddTime=@AddTime,RegUrl=@RegUrl where UserId=@UserId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(UserProfile model)
        {
            var sql = "delete from jl_user where UserId=@UserId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public PageData<UserProfile> UserPage(PageReq<UserFilter> pageReq)
        {
            throw new NotImplementedException();
        }

        public PageData<UserProfile> UserPage(PageReq pageReq)
        {
            var conn = DbConnectionFactory.CreateConnection();

            var dParas = new DynamicParameters();
            dParas.Add("@page", pageReq.PageIndex);
            dParas.Add("@pagesize", pageReq.PageSize);
            dParas.Add("@fields", "*");
            dParas.Add("@tablename", "jl_user");
            dParas.Add("@filter", "");
            dParas.Add("@orderby", pageReq.OrderBy);
            dParas.Add("@primarykey", "UserId");
            dParas.Add("@total", direction: ParameterDirection.Output);

            var data = conn.Query<UserProfile>("procPageQuery", param: dParas, commandType: CommandType.StoredProcedure);

            var total = dParas.Get<int>("@total");

            var pages = (int)Math.Ceiling((double)total / pageReq.PageSize);

            return PageData<UserProfile>.Create(pageReq.PageIndex, pageReq.PageSize, pages, total, data);
        }
        #endregion
    }
}
