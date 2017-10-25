using JL.Core.Common;
using JL.Core.Filters;
using JL.Core.Models;
using JL.Core.Repositories;
using System;

namespace JL.Infrastructure.DapperRepository
{
    public class ArticleRepository : IArticleRepository
    {
        public void DeleteArticle(int id)
        {
            throw new NotImplementedException();
        }

        public Article GetArticle(int id)
        {
            throw new NotImplementedException();
        }

        public PageData<Article> QueryArticles(PageReq<ArticleFilter> pageReq)
        {
            throw new NotImplementedException();
        }

        public void UpdateArticle(Article model)
        {
            throw new NotImplementedException();
        }
    }
}
