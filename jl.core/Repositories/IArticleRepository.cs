using JL.Core.Common;
using JL.Core.Filters;
using JL.Core.Models;
using System.Collections.Generic;

namespace JL.Core.Repositories
{
    public interface IArticleRepository
    {
        int Insert(Models.Article model);
        PageData<Models.Article> ArticlePage(PageReq pageReq);
        Models.Article GetById(int id);
        void Update(Models.Article model);
        void Delete(int id);
        void Delete(Models.Article model);
        PageData<Models.Article> ArticlePage(PageReq<ArticleFilter> pageReq);
        IEnumerable<Article> GetHotestArticle(int count);
        IEnumerable<Article> GetLatestArticle(int count);
    }
}
