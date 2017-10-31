using JL.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JL.Core.Common;
using JL.Core.Models;
using Dapper;
using System.Data;

namespace JL.Infrastructure.DapperRepository
{
    public class ProductRepository : IProductRepository
    {
        public PageData<Product> ProductPage(PageReq pageReq)
        {
            var conn = DbConnectionFactory.CreateConnection();

            var dParas = new DynamicParameters();
            dParas.Add("@page", pageReq.PageIndex);
            dParas.Add("@pagesize", pageReq.PageSize);
            dParas.Add("@fields", "*");
            dParas.Add("@tablename", "Product");
            dParas.Add("@filter", "");
            dParas.Add("@orderby", pageReq.OrderBy);
            dParas.Add("@primarykey", "AutoId");
            dParas.Add("@total", direction: ParameterDirection.Output);

            var data = conn.Query<Product>("procPageQuery", param: dParas, commandType: CommandType.StoredProcedure);

            var total = dParas.Get<int>("@total");

            var pages = (int)Math.Ceiling((double)total / pageReq.PageSize);

            return PageData<Product>.Create(pageReq.PageIndex, pageReq.PageSize, pages, data);
        }

        #region methods from t4

        public void Insert(Product model)
        {
            var connection = DbConnectionFactory.CreateConnection();
            connection.Execute(@"Insert into Product(Name,Alias,Description,Picture,RetailPrice,MarketPrice,PageViews,SortIndex,Status)
values (@Name,@Alias,@Description,@Picture,@RetailPrice,@MarketPrice,@PageViews,@SortIndex,@Status)",
                model);
        }

        public Product GetById(int id)
        {
            var query = "select * from Product where AutoId=@id";

            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<Product>(query, new { id = id }).FirstOrDefault();

        }

        public void Update(Product model)
        {
            var sql = "update Product set Name=@Name,Alias=@Alias,Description=@Description,Picture=@Picture,RetailPrice=@RetailPrice,MarketPrice=@MarketPrice,PageViews=@PageViews,SortIndex=@SortIndex,Status=@Status where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(Product model)
        {
            var sql = "delete from Product where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(int id)
        {
            var sql = "delete from Product where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, new { AutoId = id });
        }

        public void InsertProductCategory(ProductCategory model)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductCategory(ProductCategory model)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductCategory(ProductCategory model)
        {
            throw new NotImplementedException();
        }

        public PageData<ProductCategory> ProductCategoryPage(PageReq pageReq)
        {
            var conn = DbConnectionFactory.CreateConnection();

            var dParas = new DynamicParameters();
            dParas.Add("@page", pageReq.PageIndex);
            dParas.Add("@pagesize", pageReq.PageSize);
            dParas.Add("@fields", "*");
            dParas.Add("@tablename", "ProductCategory");
            dParas.Add("@filter", "");
            dParas.Add("@orderby", pageReq.OrderBy);
            dParas.Add("@primarykey", "AutoId");
            dParas.Add("@total", direction: ParameterDirection.Output);

            var data = conn.Query<ProductCategory>("procPageQuery", param: dParas, commandType: CommandType.StoredProcedure);

            var total = dParas.Get<int>("@total");

            var pages = (int)Math.Ceiling((double)total / pageReq.PageSize);

            return PageData<ProductCategory>.Create(pageReq.PageIndex, pageReq.PageSize, pages, data);
        }

        #endregion
    }
}
