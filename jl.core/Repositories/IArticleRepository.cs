using JL.Core.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Repositories
{
    public interface IArticleRepository
    {
        jl.core.Common.PageData<Models.Article> QueryArticles(jl.core.Common.PageReq<ArticleFilter> pageReq);
        Models.Article GetArticle(int id);
        void UpdateArticle(Models.Article model);
        void DeleteArticle(int id);
    }
}
