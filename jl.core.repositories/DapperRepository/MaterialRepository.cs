using Dapper;
using JL.Core.Common;
using JL.Core.Models;
using JL.Core.Repositories;
using System;
using System.Data;
using System.Linq;
using JL.Core.Filters;
using JL.Infrastructure;

namespace JL.Core.Repositories.DapperRepository
{
    public class MaterialRepository : IMaterialRepository
    {
        public PageData<Material> MaterialPage(PageReq pageReq)
        {
            var conn = DbConnectionFactory.CreateConnection();

            var dParas = new DynamicParameters();
            dParas.Add("@page", pageReq.PageIndex);
            dParas.Add("@pagesize", pageReq.PageSize);
            dParas.Add("@fields", "*");
            dParas.Add("@tablename", "Material");
            dParas.Add("@filter", "");
            dParas.Add("@orderby", pageReq.OrderBy);
            dParas.Add("@primarykey", "AutoId");
            dParas.Add("@total", direction: ParameterDirection.Output);

            var data = conn.Query<Material>("procPageQuery", param: dParas, commandType: CommandType.StoredProcedure);

            var total = dParas.Get<int>("@total");

            var pages = (int)Math.Ceiling((double)total / pageReq.PageSize);

            return PageData<Material>.Create(pageReq.PageIndex, pageReq.PageSize, pages, total, data);
        }

        public PageData<Material> MaterialPage(PageReq<MaterialFilter> pageReq)
        {
            var conn = DbConnectionFactory.CreateConnection();

            var dParas = new DynamicParameters();
            dParas.Add("@page", pageReq.PageIndex);
            dParas.Add("@pagesize", pageReq.PageSize);
            dParas.Add("@fields", "*");
            dParas.Add("@tablename", "Material");
            dParas.Add("@filter", BuildSqlFrom(pageReq.Data));
            dParas.Add("@orderby", pageReq.OrderBy);
            dParas.Add("@primarykey", "AutoId");
            dParas.Add("@total", direction: ParameterDirection.Output);

            var data = conn.Query<Material>("procPageQuery", param: dParas, commandType: CommandType.StoredProcedure);

            var total = dParas.Get<int>("@total");

            var pages = (int)Math.Ceiling((double)total / pageReq.PageSize);

            return PageData<Material>.Create(pageReq.PageIndex, pageReq.PageSize, pages, total, data);
        }

        private string BuildSqlFrom(MaterialFilter filter)
        {
            if (filter == null)
            {
                return null;
            }

            var sb = new System.Text.StringBuilder();
            if (filter.AddTimeFrom.HasValue)
            {
                sb.Append(" addtime >= " + filter.AddTimeFrom.Value.ToString("yyyy-MM-dd"));
                sb.Append(" and ");
            }
            if (filter.AddTimeTo.HasValue)
            {
                sb.Append(" addtime <= " + filter.AddTimeTo.Value.ToString("yyyy-MM-dd"));
                sb.Append(" and ");
            }
            if (filter.MaterialType > 0)
            {
                sb.AppendFormat(" materialtype = '{0}' ", SqlFilter.FilterQueryParameter(filter.MaterialType.Value.ToString()));
                sb.Append(" and ");
            }
            if (!string.IsNullOrEmpty(filter.Title))
            {
                sb.AppendFormat(" title like '{0}' ", SqlFilter.FilterQueryParameter(filter.Title));
                sb.Append(" and ");
            }

            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 4, 4);
            }

            return sb.ToString();
        }

        #region methods from t4

        public int Insert(Material model)
        {
            var connection = DbConnectionFactory.CreateConnection();
            var id=connection.Query<int>(@"Insert into Material(Title,Description,Picture,FileName,MaterialType,PageViews,SortIndex,Status,Url,AddTime)
values (@Title,@Description,@Picture,@FileName,@MaterialType,@PageViews,@SortIndex,@Status,@Url,@AddTime);SELECT LAST_INSERT_ID()",
                model).FirstOrDefault();
            return id;
        }

        public Material GetById(int id)
        {
            var query = "select * from Material where AutoId=@id";

            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<Material>(query, new { id = id }).FirstOrDefault();

        }

        public void Update(Material model)
        {
            var sql = "update Material set Title=@Title,Description=@Description,Picture=@Picture,FileName=@FileName,MaterialType=@MaterialType,PageViews=@PageViews,SortIndex=@SortIndex,Status=@Status,Url=@Url where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(Material model)
        {
            var sql = "delete from Material where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(int id)
        {
            var sql = "delete from Material where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, new { AutoId = id });
        }


        #endregion
    }
}
