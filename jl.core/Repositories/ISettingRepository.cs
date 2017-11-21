using JL.Core.Common;
using JL.Core.Filters;
using System.Collections.Generic;

namespace JL.Core.Repositories
{
    public interface ISettingRepository
    {
        int Insert(Models.Setting model);
        Models.Setting GetById(int id);
        void Update(Models.Setting model);
        void Delete(int id);
        void Delete(Models.Setting model);
        IEnumerable<Models.Setting> GetList();
    }
}
