using Dapper;
using JL.Core.Common;
using JL.Core.Filters;
using JL.Core.Models;
using JL.Core.Repositories;
using System;
using System.Linq;

namespace JL.Infrastructure.DapperRepository
{
    public partial class ArticleRepository : IArticleRepository
    {        
        #region methodes from t4

        public void Add(Article model)
        {
            var connection = DbConnectionFactory.CreateConnection();
            connection.Execute(@"Insert into Article(Title,Content,Picture,AddTime,Tags,PageViews,SortIndex,Status)
values (@Title,@Content,@Picture,@AddTime,@Tags,@PageViews,@SortIndex,@Status)",
                model);
        }

        public Article GetById(int id)
        {
            var query = "select * from Article where AutoId=@id";

            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<Article>(query, new { id = id }).FirstOrDefault();

        }

        public void Update(Article model)
        {
            var sql = "update Article set Title=@Title,Content=@Content,Picture=@Picture,AddTime=@AddTime,Tags=@Tags,PageViews=@PageViews,SortIndex=@SortIndex,Status=@Status where AutoId=@AutoId";
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
        
        public PageData<Article> ArticlePage(PageReq<ArticleFilter> pageReq)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
