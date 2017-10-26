using JL.Core.Common;
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
        void Add(Member model);
        void Update(Member model);
        Member GetById(int id);
        PageData<Member> FranchiseePage(PageReq pageReq);
        void Delete(int id);
        void Delete(Member model);
    }
}
