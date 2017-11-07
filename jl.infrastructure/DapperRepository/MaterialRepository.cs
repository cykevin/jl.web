using Dapper;
using JL.Core.Common;
using JL.Core.Models;
using JL.Core.Repositories;
using System;
using System.Data;
using System.Linq;

namespace JL.Infrastructure.DapperRepository
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

        #region methods from t4

        public int Insert(Material model)
        {
            var connection = DbConnectionFactory.CreateConnection();
            var id=connection.Query<int>(@"Insert into Material(Title,Description,Picture,FileName,MaterialType,PageViews,SortIndex,Status,Url)
values (@Title,@Description,@Picture,@FileName,@MaterialType,@PageViews,@SortIndex,@Status,@Url);SELECT LAST_INSERT_ID()",
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
