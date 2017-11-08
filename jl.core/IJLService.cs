using JL.Core.Common;
using JL.Core.Filters;
using JL.Core.Models;
using System.Collections.Generic;

namespace JL.Core
{
    public interface IJLService
    {
        // article
        int AddArticle(Article article);
        PageData<Article> ArticlePage(PageReq pageReq);
        PageData<Article> ArticlePage(PageReq<ArticleFilter> pageReq);
        void DeleteArticle(Article article);
        void UpdateArticle(Article model);
        Article GetArticle(int id);

        // material
        int AddMaterial(Material model);
        void DeleteMaterial(Material model);
        void UpdateMaterial(Material model);
        PageData<Material> MaterialPage(PageReq pageReq);

        // member
        int AddMember(Member model);
        void DeleteMember(Member model);
        void UpdateMember(Member model);
        PageData<Member> MemberPage(PageReq pageReq);

        // product
        int AddProduct(Product model);
        Product GetProduct(int id);
        void DeleteProduct(Product model);
        void UpdateProduct(Product model);
        PageData<Product> ProductPage(PageReq pageReq);
        PageData<Product> ProductPage(PageReq<ProductFilter> pageReq);

        int AddProductCategory(ProductCategory model);
        ProductCategory GetProductCategory(int id);
        void DeleteProductCategory(ProductCategory model);
        void UpdateProductCategory(ProductCategory model);
        PageData<ProductCategory> ProductCategoryPage(PageReq pageReq);
        void ProductToCategory(int productId, System.Collections.Generic.IEnumerable<int> categoryIds);
        IEnumerable<ProductCategory> GetProductCategoryList();

        // franchisee
        void DeleteFranchisee(Franchisee model);
        int AddFranchisee(Franchisee model);
        void UpdateFranchisee(Franchisee model);
        void FranchiseePage(PageReq pageReq);

        // userprofile
        int AddUser(UserProfile user);
        void UpdateUser(UserProfile user);
        UserProfile GetUser(int id);
        UserProfile GetUser(string username);
        PageData<UserProfile> UserPage(PageReq pageReq);
    }
}
