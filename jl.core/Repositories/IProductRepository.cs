using JL.Core.Common;
using JL.Core.Models;

namespace JL.Core.Repositories
{
    public interface IProductRepository
    {
        void Add(Product model);
        void Update(Product model);
        Product GetById(int id);
        PageData<Product> FranchiseePage(PageReq pageReq);
        void Delete(int id);
        void Delete(Product model);
    }
}
