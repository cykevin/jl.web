using JL.Core.Common;
using JL.Core.Models;

namespace JL.Core
{
    public interface IJLService
    {
        // article
        void InsertArticle(Article article);
        PageData<Article> ArticlePage(PageReq pageReq);
        void DeleteArticle(Article article);
        void UpdateArticle(Article model);
        Article GetArticle(int id);

        // material
        void InsertMaterial(Material model);
        void DeleteMaterial(Material model);
        void UpdateMaterial(Material model);
        PageData<Material> MaterialPage(PageReq pageReq);

        // member
        void InsertMember(Member model);
        void DeleteMember(Member model);
        void UpdateMember(Member model);
        PageData<Member> MemberPage(PageReq pageReq);

        // product
        void InsertProduct(Product model);
        void DeleteProduct(Product model);
        void UpdateProduct(Product model);
        PageData<Product> ProductPage(PageReq pageReq);

        void InsertProductCategory(ProductCategory model);
        void DeleteProductCategory(ProductCategory model);
        void UpdateProductCategory(ProductCategory model);
        PageData<ProductCategory> ProductCategoryPage(PageReq pageReq);
        

        // franchisee
        void DeleteFranchisee(Franchisee model);
        void InsertFranchisee(Franchisee model);
        void UpdateFranchisee(Franchisee model);
        void FranchiseePage(PageReq pageReq);

        // userprofile
        void AddUser(UserProfile user);
        void UpdateUser(UserProfile user);
        UserProfile GetUser(int id);
        UserProfile GetUser(string username);
        PageData<UserProfile> UserPage(PageReq pageReq);
    }
}
