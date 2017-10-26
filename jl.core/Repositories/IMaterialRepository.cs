using JL.Core.Common;
using JL.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL.Core.Repositories
{
    public interface IMaterialRepository
    {
        void Add(Material model);
        void Update(Material model);
        Material GetById(int id);
        PageData<Material> FranchiseePage(PageReq pageReq);
        void Delete(int id);
        void Delete(Material model);
    }
}
