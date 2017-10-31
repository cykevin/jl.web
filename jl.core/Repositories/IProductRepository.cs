using JL.Core.Common;
using JL.Core.Models;

namespace JL.Core.Repositories
{
    public interface IProductRepository
    {
        void Insert(Product model);
        void Update(Product model);
        Product GetById(int id);
        PageData<Product> ProductPage(PageReq pageReq);
        void Delete(int id);
        void Delete(Product model);

        // product category
        void InsertProductCategory(ProductCategory model);
        void DeleteProductCategory(ProductCategory model);
        void UpdateProductCategory(ProductCategory model);
        PageData<ProductCategory> ProductCategoryPage(PageReq pageReq);
    }
}
