using Dapper;
using JL.Core.Common;
using JL.Core.Models;
using JL.Core.Repositories;
using JL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace JL.Core.Repositories.DapperRepository
{
    public partial class BannerRepository : IBannerRepository
    {
        public int Insert(Banner model)
        {
            var connection = DbConnectionFactory.CreateConnection();
            var id=connection.Query<int>(@"Insert into banner(Title,Desctiption,Picture,BackgroundColor,Status,SortIndex)
values (@Title,@Desctiption,@Picture,@BackgroundColor,@Status,@SortIndex)",
                model).FirstOrDefault();
            return id;
        }

        public Banner GetById(int id)
        {
            var query = "select * from banner where AutoId=@id";

            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<Banner>(query, new { id = id }).FirstOrDefault();

        }

        public void Update(Banner model)
        {
            var sql = "update banner set Title=@Title,Desctiption=@Desctiption,Picture=@Picture,BackgroundColor=@BackgroundColor,Status=@Status,SortIndex=@SortIndex where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(Banner model)
        {
            var sql = "delete from banner where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(int id)
        {
            var sql = "delete from banner where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, new { AutoId = id });
        }

        public PageData<Banner> BannerPage(PageReq pageReq)
        {
            var conn = DbConnectionFactory.CreateConnection();

            var dParas = new DynamicParameters();
            dParas.Add("@page", pageReq.PageIndex);
            dParas.Add("@pagesize", pageReq.PageSize);
            dParas.Add("@fields", "*");
            dParas.Add("@tablename", "banner");
            dParas.Add("@filter", "");
            dParas.Add("@orderby", pageReq.OrderBy);
            dParas.Add("@primarykey", "AutoId");
            dParas.Add("@total", direction: ParameterDirection.Output);

            var data = conn.Query<Banner>("procPageQuery", param: dParas, commandType: CommandType.StoredProcedure);

            var total = dParas.Get<int>("@total");

            var pages = (int)Math.Ceiling((double)total / pageReq.PageSize);

            return PageData<Banner>.Create(pageReq.PageIndex, pageReq.PageSize, pages, total, data);
        }


        public IEnumerable<Banner> GetList()
        {
            var conn = DbConnectionFactory.CreateConnection();
            var sql = "select * from Banner";
            var data = conn.Query<Banner>(sql);
            return data;
        }

    }
}
