using JL.Core.Common;
using JL.Core.Filters;
using JL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Repositories
{
    public interface IMemberRepository
    {
        int Insert(Member model);
        void Update(Member model);
        Member GetById(int id);
        PageData<Member> MemberPage(PageReq pageReq);
        PageData<Member> MemberPage(PageReq<MemberFilter> pageReq);
        void Delete(int id);
        void Delete(Member model);
    }
}
