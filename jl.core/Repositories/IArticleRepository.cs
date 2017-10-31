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
        void Insert(Models.Article model);
        JL.Core.Common.PageData<Models.Article> ArticlePage(JL.Core.Common.PageReq pageReq);
        Models.Article GetById(int id);
        void Update(Models.Article model);
        void Delete(int id);
        void Delete(Models.Article model);
    }
}
