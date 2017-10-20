using jl.core.Common.Filters;
using JL.Core.Models;
using System;
using System.Collections.Generic;

namespace jl.core.Repositories
{
    public interface IUserRepository : IDisposable
    {
        UserProfile GetByUsername(string username);
        UserProfile GetById(int id);
        List<UserProfile> GetAll(UserProfileFilterOptions filter, Common.PagingSetting paging = null);
        int Total(Common.Filters.UserProfileFilterOptions filter);
        void Save(UserProfile userProfile);
    }
}
