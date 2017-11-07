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
using JL.Core.Filters;

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

            return PageData<Product>.Create(pageReq.PageIndex, pageReq.PageSize, pages, total, data);
        }

        #region methods from t4

        public int Insert(Product model)
        {
            var connection = DbConnectionFactory.CreateConnection();
            var id=connection.Query<int>(@"Insert into Product(Name,Alias,Description,Picture,RetailPrice,MarketPrice,PageViews,SortIndex,Status)
values (@Name,@Alias,@Description,@Picture,@RetailPrice,@MarketPrice,@PageViews,@SortIndex,@Status);SELECT LAST_INSERT_ID()",
                model).FirstOrDefault();
            return id;
        }

        public Product GetById(int id)
        {
            var query = "select * from Product where AutoId=@id";

            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<Product>(query, new { id = id }).FirstOrDefault();

        }


        public ProductCategory GetProductCategory(int id)
        {
            var query = "select pc.*,p.* from productcategory pc left join productcategorylink pcl on pc.AutoId = pcl.categoryid left join product p on pcl.productid = p.autoid where AutoId=@id";

            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<ProductCategory, Product, ProductCategory>(query,(pc,p)=> {
                pc.Products.Add(p);
                return pc;
            }, new { id = id }).FirstOrDefault();
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

        public int InsertProductCategory(ProductCategory model)
        {
            var connection = DbConnectionFactory.CreateConnection();
            var id=connection.Query<int>(@"Insert into productcategory(Name,Alias,Picture,Path,Depth,ParentId,PageViews,SortIndex,Status)
values (@Name,@Alias,@Picture,@Path,@Depth,@ParentId,@PageViews,@SortIndex,@Status);SELECT LAST_INSERT_ID()",
                model).FirstOrDefault();
            return id;
        }

        public ProductCategory GetProductCategoryById(int id)
        {
            var query = "select pc.*,p.* from productcategory pc left join productcategorylink pcl on pc.AutoId = pcl.categoryid left join product p on pcl.productid = p.autoid where pc.AutoId=@id";

            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<ProductCategory, Product, ProductCategory>(query, (pc, p) =>
            {
                pc.Products.Add(p);
                return pc;
            }, new { id = id },splitOn: "Name").FirstOrDefault();
        }

        public void UpdateProductCategory(ProductCategory model)
        {
            var sql = "update productcategory set Name=@Name,Alias=@Alias,Picture=@Picture,Path=@Path,Depth=@Depth,ParentId=@ParentId,PageViews=@PageViews,SortIndex=@SortIndex,Status=@Status where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void DeleteProductCategory(ProductCategory model)
        {
            var sql = "delete from productcategory where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void DeleteProductCategory(int id)
        {
            var sql = "delete from productcategory where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, new { AutoId = id });
        }

        public PageData<ProductCategory> ProductCategoryPage(PageReq pageReq)
        {
            using (var conn = DbConnectionFactory.CreateConnection())
            {
                conn.Open();

                var dParas = new DynamicParameters();
                dParas.Add("@page", pageReq.PageIndex);
                dParas.Add("@pagesize", pageReq.PageSize);
                dParas.Add("@fields", "*");
                dParas.Add("@tablename", "productcategory");
                dParas.Add("@filter", "");
                dParas.Add("@orderby", pageReq.OrderBy);
                dParas.Add("@primarykey", "AutoId");
                dParas.Add("@total", direction: ParameterDirection.Output);

                var data = conn.Query<ProductCategory>("procPageQuery",
                    param: dParas, commandType: CommandType.StoredProcedure);

                var total = dParas.Get<int>("@total");

                if (data != null)
                {
                    foreach (var pc in data)
                    {
                        var sql = "select p.* from product p left join productcategorylink l on p.autoid=l.productid where l.categoryid=" + pc.AutoId;

                        pc.Products = conn.Query<Product>(sql).ToList();
                    }
                }

                var pages = (int)Math.Ceiling((double)total / pageReq.PageSize);

                return PageData<ProductCategory>.Create(pageReq.PageIndex, pageReq.PageSize, pages, total, data);
            }
        }


        public void SetProductToCategory(int productId, int categoryId)
        {
            var connection = DbConnectionFactory.CreateConnection();
            connection.Execute(@"Insert into productcategorylink(productId,categoryId)
values(@productId,@categoryId)",
                new { productId = productId, categoryId = categoryId });
        }

        public void SetProductToCategory(int productId, IEnumerable<int> categoryIds)
        {
            var sqlBuilder = new StringBuilder();
            sqlBuilder.Append(" Insert into productcategorylink(productId,categoryId) ");
            sqlBuilder.Append(" Values ");
            foreach (var cateid in categoryIds)
            {
                sqlBuilder.AppendFormat(" ({0},{1}),", productId, cateid);
            }
            sqlBuilder.Remove(sqlBuilder.Length - 1, 1);
            sqlBuilder.Append(";");

            var connection = DbConnectionFactory.CreateConnection();
            connection.Execute(sqlBuilder.ToString());
        }

        public IEnumerable<ProductCategory> GetProductCategoryList()
        {
            var query = "select * from ProductCategory";

            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<ProductCategory>(query);
        }

        public PageData<Product> ProductPage(PageReq<ProductFilter> pageReq)
        {
            var conn = DbConnectionFactory.CreateConnection();

            var dParas = new DynamicParameters();
            dParas.Add("@page", pageReq.PageIndex);
            dParas.Add("@pagesize", pageReq.PageSize);
            dParas.Add("@fields", "p.*");
            dParas.Add("@tablename", " Product p left join productcategorylink l on p.autoid=l.productid ");
            dParas.Add("@filter", BuildSqlFrom(pageReq.Data));
            dParas.Add("@orderby", pageReq.OrderBy);
            dParas.Add("@primarykey", "AutoId");
            dParas.Add("@total", direction: ParameterDirection.Output);

            var data = conn.Query<Product>("procPageQuery", param: dParas, commandType: CommandType.StoredProcedure);
            
            if (data != null)
            {
                foreach (var p in data)
                {
                    var sql = "select pc.* from productcategory pc left join productcategorylink l on pc.autoid=l.categoryid where l.productid=" + p.AutoId;

                    p.Categories = conn.Query<ProductCategory>(sql).ToList();
                }
            }

            var total = dParas.Get<int>("@total");

            var pages = (int)Math.Ceiling((double)total / pageReq.PageSize);

            return PageData<Product>.Create(pageReq.PageIndex, pageReq.PageSize, pages, total, data);
        }

        private string BuildSqlFrom(ProductFilter filter)
        {
            if(filter!=null)
            {
                StringBuilder sb = new StringBuilder();
                if(filter.CategoryId>0)
                {
                    sb.Append("l.categoryid=" + filter.CategoryId);
                    sb.Append(" and ");
                }
                if(!string.IsNullOrEmpty(filter.Title))
                {
                    sb.Append("p.title like '%@title%'");
                    sb.Append(" and ");
                }

                if (sb.Length > 0)
                    return sb.Remove(sb.Length - 4, 4).ToString();
            }

            return null;
        }
        #endregion
    }
}
