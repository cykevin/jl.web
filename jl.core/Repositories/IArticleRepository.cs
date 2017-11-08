using JL.Core.Common;
using JL.Core.Filters;

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
    }
}
