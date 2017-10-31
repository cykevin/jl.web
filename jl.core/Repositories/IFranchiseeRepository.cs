using JL.Core.Common;
using JL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Repositories
{
    public interface IFranchiseeRepository
    {
        void Insert(Franchisee model);
        void Update(Franchisee model);
        Franchisee GetById(int id);
        PageData<Franchisee> FranchiseePage(PageReq pageReq);
        void Delete(int id);
        void Delete(Franchisee model);
    }
}
