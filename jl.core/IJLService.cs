using JL.Core.Common;
using JL.Core.Models;

namespace JL.Core
{
    public interface IJLService
    {
        // article
        int AddArticle(Article article);
        PageData<Article> ArticlePage(PageReq pageReq);
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
        void DeleteProduct(Product model);
        void UpdateProduct(Product model);
        PageData<Product> ProductPage(PageReq pageReq);

        int AddProductCategory(ProductCategory model);
        void DeleteProductCategory(ProductCategory model);
        void UpdateProductCategory(ProductCategory model);
        PageData<ProductCategory> ProductCategoryPage(PageReq pageReq);
        

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
