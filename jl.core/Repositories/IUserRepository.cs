using JL.Core.Common;
using JL.Core.Filters;
using JL.Core.Models;
using System;
using System.Collections.Generic;

namespace JL.Core.Repositories
{
    public interface IUserRepository
    {
        UserProfile GetByUsername(string username);
        UserProfile GetById(int id);
        PageData<UserProfile> UserPage(PageReq<UserFilter> pageReq);
        PageData<UserProfile> UserPage(PageReq pageReq);
        int Insert(UserProfile userProfile);
        void Delete(UserProfile userProfile);
        void Update(UserProfile userProfile);
    }
}
