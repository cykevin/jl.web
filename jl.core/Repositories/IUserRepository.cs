using jl.core.Common;
using JL.Core.Filters;
using JL.Core.Models;
using System;
using System.Collections.Generic;

namespace jl.core.Repositories
{
    public interface IUserRepository
    {
        UserProfile GetByUsername(string username);
        UserProfile GetById(int id);
        PageData<UserProfile> UserPage(PageReq<UserFilter> pageReq);
        PageData<UserProfile> UserPage(PageReq pageReq);
        void Save(UserProfile userProfile);
    }
}
