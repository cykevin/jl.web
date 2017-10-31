  


using System.Linq;
using JL.Core.Models;
using Dapper;
using JL.Core.Common;
using System.Data;
using System;

namespace JL.Infrastructure.DapperRepository
{
	public partial class UserProfileRepository
	{
		public void Insert(UserProfile model)
		{
			var connection = DbConnectionFactory.CreateConnection();
			connection.Execute(@"Insert into jl_user(UserName,Cellphone,IsCellphoneConfirmed,Email,IsEmailConfirmed,RealName,NickName,Telephone,Birthday,Gender,QQ,Address,AddTime,RegUrl)
values (@UserName,@Cellphone,@IsCellphoneConfirmed,@Email,@IsEmailConfirmed,@RealName,@NickName,@Telephone,@Birthday,@Gender,@QQ,@Address,@AddTime,@RegUrl)",
				model);
		}

	    public UserProfile GetById(int id)
		{
			var query="select * from jl_user where UserId=@id";

			var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<UserProfile>(query, new { id = id }).FirstOrDefault();

		}

		public void Update(UserProfile model)
		{
			var sql="update jl_user set UserName=@UserName,Cellphone=@Cellphone,IsCellphoneConfirmed=@IsCellphoneConfirmed,Email=@Email,IsEmailConfirmed=@IsEmailConfirmed,RealName=@RealName,NickName=@NickName,Telephone=@Telephone,Birthday=@Birthday,Gender=@Gender,QQ=@QQ,Address=@Address,AddTime=@AddTime,RegUrl=@RegUrl where UserId=@UserId";
			var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
		}

		public void Delete(UserProfile model)
		{
			var sql="delete from jl_user where UserId=@UserId";
			var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
		}

		public void Delete(int id)
		{
			var sql="delete from jl_user where UserId=@UserId";
			var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, new{UserId = id});
		}

		public PageData<UserProfile> UserProfilePage(PageReq pageReq)
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

            return PageData<UserProfile>.Create(pageReq.PageIndex, pageReq.PageSize, pages, data);
        }
	}
}
