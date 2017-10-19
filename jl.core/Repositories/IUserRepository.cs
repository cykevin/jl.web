using jl.core.Common.Filters;
using Maticsoft.Model;
using System;
using System.Collections.Generic;

namespace jl.core.Repositories
{
    public interface IUserRepository : IDisposable
    {
        jl_user GetByUsername(string username);
        jl_user GetById(int id);
        List<jl_user> GetAll(UserProfileFilterOptions filter, Common.PagingSetting paging = null);
        int Total(Common.Filters.UserProfileFilterOptions filter);
        void Save(jl_user userProfile);
    }
}
