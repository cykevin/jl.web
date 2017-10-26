using Dapper;
using JL.Core.Common;
using JL.Core.Models;
using JL.Core.Repositories;
using System;
using System.Linq;

namespace JL.Infrastructure.DapperRepository
{
    public class MaterialRepository : IMaterialRepository
    {
        public PageData<Material> FranchiseePage(PageReq pageReq)
        {
            throw new NotImplementedException();
        }

        #region methods from t4

        public void Add(Material model)
        {
            var connection = DbConnectionFactory.CreateConnection();
            connection.Execute(@"Insert into Material(Title,Description,Picture,FileName,MaterialType,PageViews,SortIndex,Status,Url)
values (@Title,@Description,@Picture,@FileName,@MaterialType,@PageViews,@SortIndex,@Status,@Url)",
                model);
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
