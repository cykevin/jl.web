using JL.Core.Common;
using JL.Core.Filters;
using JL.Core.Models;
using System.Collections.Generic;

namespace JL.Core.Repositories
{
    public interface IProductRepository
    {
        int Insert(Product model);
        void Update(Product model);
        Product GetById(int id);
        PageData<Product> ProductPage(PageReq pageReq);
        PageData<Product> ProductPage(PageReq<ProductFilter> pageReq);
        void Delete(int id);
        void Delete(Product model);
        IEnumerable<Product> GetList(string where, string fields , int top, string orderBy );

        // product category
        ProductCategory GetProductCategoryById(int id);
        int InsertProductCategory(ProductCategory model);
        void DeleteProductCategory(ProductCategory model);
        void UpdateProductCategory(ProductCategory model);
        PageData<ProductCategory> ProductCategoryPage(PageReq pageReq);
        IEnumerable<ProductCategory> GetProductCategoryList();

        void SetProductToCategory(int productId, int categoryId);
        void SetProductToCategory(int productId, System.Collections.Generic.IEnumerable<int> categoryId);
    }
}
