


using Dapper;
using JL.Core.Common;
using JL.Core.Models;
using System;
using System.Data;
using System.Linq;

namespace JL.Infrastructure.DapperRepository
{
    public partial class ProductCategoryRepository
	{
		public void Insert(ProductCategory model)
		{
			var connection = DbConnectionFactory.CreateConnection();
			connection.Execute(@"Insert into productcategory(Name,Alias,Picture,Path,Depth,ParentId,PageViews,SortIndex,Status)
values (@Name,@Alias,@Picture,@Path,@Depth,@ParentId,@PageViews,@SortIndex,@Status)",
				model);
		}

	    public ProductCategory GetById(int id)
		{
			var query="select * from productcategory where AutoId=@id";

			var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<ProductCategory>(query, new { id = id }).FirstOrDefault();

		}

		public void Update(ProductCategory model)
		{
			var sql="update productcategory set Name=@Name,Alias=@Alias,Picture=@Picture,Path=@Path,Depth=@Depth,ParentId=@ParentId,PageViews=@PageViews,SortIndex=@SortIndex,Status=@Status where AutoId=@AutoId";
			var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
		}

		public void Delete(ProductCategory model)
		{
			var sql="delete from productcategory where AutoId=@AutoId";
			var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
		}

		public void Delete(int id)
		{
			var sql="delete from productcategory where AutoId=@AutoId";
			var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, new{AutoId = id});
		}

		public PageData<ProductCategory> ProductCategoryPage(PageReq pageReq)
        {
            var conn = DbConnectionFactory.CreateConnection();
            
            var dParas = new DynamicParameters();
            dParas.Add("@page", pageReq.PageIndex);
            dParas.Add("@pagesize", pageReq.PageSize);
            dParas.Add("@fields", "*");
            dParas.Add("@tablename", "productcategory");
            dParas.Add("@filter", "");
            dParas.Add("@orderby", pageReq.OrderBy);
            dParas.Add("@primarykey", "AutoId");
            dParas.Add("@total", direction: ParameterDirection.Output);

            var data = conn.Query<ProductCategory>("procPageQuery", param: dParas, commandType: CommandType.StoredProcedure);

            var total = dParas.Get<int>("@total");

            var pages = (int)Math.Ceiling((double)total / pageReq.PageSize);

            return PageData<ProductCategory>.Create(pageReq.PageIndex, pageReq.PageSize, pages, data);
        }
	}
}
