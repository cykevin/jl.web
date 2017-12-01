using Dapper;
using JL.Core.Common;
using JL.Core.Filters;
using JL.Core.Models;
using JL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace JL.Core.Repositories.DapperRepository
{
    public partial class ArticleRepository : IArticleRepository
    {
        #region methodes from t4

        public int Insert(Article model)
        {
            var connection = DbConnectionFactory.CreateConnection();
            var id = connection.Query<int>(@"Insert into Article(Title,Brief,Content,Picture,AddTime,Tags,PageViews,SortIndex,Status)
values (@Title,@Brief,@Content,@Picture,@AddTime,@Tags,@PageViews,@SortIndex,@Status);SELECT LAST_INSERT_ID()",
                model).FirstOrDefault();
            return id;
        }

        public Article GetById(int id)
        {
            var query = "select * from Article where AutoId=@id";

            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<Article>(query, new { id = id }).FirstOrDefault();

        }

        public void Update(Article model)
        {
            var sql = "update Article set Title=@Title,Brief=@Brief,Content=@Content,Picture=@Picture,AddTime=@AddTime,Tags=@Tags,PageViews=@PageViews,SortIndex=@SortIndex,Status=@Status where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(Article model)
        {
            var sql = "delete from Article where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(int id)
        {
            var sql = "delete from Article where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, new { AutoId = id });
        }

        public PageData<Article> ArticlePage(PageReq pageReq)
        {
            var conn = DbConnectionFactory.CreateConnection();

            var dParas = new DynamicParameters();
            dParas.Add("@page", pageReq.PageIndex);
            dParas.Add("@pagesize", pageReq.PageSize);
            dParas.Add("@fields", "*");
            dParas.Add("@tablename", "Article");
            dParas.Add("@filter", "");
            dParas.Add("@orderby", pageReq.OrderBy);
            dParas.Add("@primarykey", "AutoId");
            dParas.Add("@total", direction: ParameterDirection.Output);

            var data = conn.Query<Article>("procPageQuery", param: dParas, commandType: CommandType.StoredProcedure);

            var total = dParas.Get<int>("@total");

            var pages = (int)Math.Ceiling((double)total / pageReq.PageSize);

            return PageData<Article>.Create(pageReq.PageIndex, pageReq.PageSize, pages, total, data);
        }

        public IEnumerable<Article> GetList()
        {
            var conn = DbConnectionFactory.CreateConnection();
            var sql = "select * from Article";
            var data = conn.Query<Article>(sql);
            return data;
        }       

        public PageData<Article> ArticlePage(PageReq<ArticleFilter> pageReq)
        {
            var conn = DbConnectionFactory.CreateConnection();

            var dParas = new DynamicParameters();
            dParas.Add("@page", pageReq.PageIndex);
            dParas.Add("@pagesize", pageReq.PageSize);
            dParas.Add("@fields", "*");
            dParas.Add("@tablename", "Article");
            dParas.Add("@filter", BuildSqlFrom(pageReq.Data));
            dParas.Add("@orderby", pageReq.OrderBy);
            dParas.Add("@primarykey", "AutoId");
            dParas.Add("@total", direction: ParameterDirection.Output);

            var data = conn.Query<Article>("procPageQuery", param: dParas, commandType: CommandType.StoredProcedure);

            var total = dParas.Get<int>("@total");

            var pages = (int)Math.Ceiling((double)total / pageReq.PageSize);

            return PageData<Article>.Create(pageReq.PageIndex, pageReq.PageSize, pages, total, data);
        }

        private string BuildSqlFrom(ArticleFilter filter)
        {
            if (filter != null)
            {
                StringBuilder sb = new StringBuilder();

                if (!string.IsNullOrEmpty(filter.Title))
                {
                    sb.Append("title like '%" + filter.Title + "%'");
                    sb.Append(" and ");
                }
                if (filter.Status > -1)
                {
                    sb.Append(" status = " + filter.Status);
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
