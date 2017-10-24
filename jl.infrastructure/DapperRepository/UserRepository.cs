using jl.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jl.core.Common;
using JL.Core.Models;
using JL.Core.Filters;
using Dapper;

namespace jl.infrastructure.DapperRepository
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

        public void Save(UserProfile userProfile)
        {
            this.Add(userProfile);
        }

        public PageData<UserProfile> UserPage(PageReq pageReq)
        {
            throw new NotImplementedException();
        }

        public PageData<UserProfile> UserPage(PageReq<UserFilter> pageReq)
        {
            var conn = DbConnectionFactory.CreateConnection();
            var cmd = conn.CreateCommand();
            
            throw new NotImplementedException();
        }

        #region methods from t4

        public void Add(UserProfile model)
        {
            var connection = DbConnectionFactory.CreateConnection();
            connection.Execute(@"Insert into Users(UserName,Cellphone,IsCellphoneConfirmed,Email,IsEmailConfirmed,RealName,NickName,Telephone,Birthday,Gender,QQ,Address,AddTime,RegUrl)
values (@UserName,@Cellphone,@IsCellphoneConfirmed,@Email,@IsEmailConfirmed,@RealName,@NickName,@Telephone,@Birthday,@Gender,@QQ,@Address,@AddTime,@RegUrl)",
                model);
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

        #endregion
    }
}
