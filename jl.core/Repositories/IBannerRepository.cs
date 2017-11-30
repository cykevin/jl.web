using JL.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Repositories
{
    public interface IBannerRepository
    {
        int Insert(Models.Banner model);
        PageData<Models.Banner> BannerPage(PageReq pageReq);
        IEnumerable<Models.Banner> GetList();
        Models.Banner GetById(int id);
        void Update(Models.Banner model);
        void Delete(int id);
        void Delete(Models.Banner model);
    }
}
