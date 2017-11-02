using JL.Core.Common;
using JL.Core.Repositories;
using JL.Core.Models;
using System;

namespace JL.Core.Providers
{
    public class JLService : IJLService
    {
        private readonly IUserRepository userRepository;
        private readonly IArticleRepository articleRepository;
        private readonly IProductRepository productRepository;
        private readonly IMemberRepository memberRepository;
        private readonly IFranchiseeRepository franchiseeRepository;
        private readonly IMaterialRepository materialRepository;

        public JLService(IUserRepository userRepository,
            IArticleRepository articleRepository,
            IProductRepository productRepository,
            IMemberRepository memberRepository,
            IFranchiseeRepository franchiseeRepository,
            IMaterialRepository materialRepository)
        {
            this.userRepository = userRepository;
            this.articleRepository = articleRepository;
            this.productRepository = productRepository;
            this.memberRepository = memberRepository;
            this.franchiseeRepository = franchiseeRepository;
            this.materialRepository = materialRepository;
        }

        #region userprofile

        public int AddUser(UserProfile user)
        {
            return userRepository.Insert(user);
        }

        public void UpdateUser(UserProfile user)
        {
            userRepository.Update(user);
        }

        public PageData<UserProfile> UserPage(PageReq pageReq)
        {
            return userRepository.UserPage(pageReq);
        }

        public UserProfile GetUser(int id)
        {
            return userRepository.GetById(id);
        }

        public UserProfile GetUser(string username)
        {
            return userRepository.GetByUsername(username);
        }

        #endregion

        #region article

        public void UpdateArticle(Article model)
        {
            articleRepository.Update(model);
        }

        public PageData<Article> ArticlePage(PageReq pageReq)
        {
            return articleRepository.ArticlePage(pageReq);
        }

        public void DeleteArticle(Article article)
        {
            articleRepository.Delete(article);
        }

        public int AddArticle(Article article)
        {
            return articleRepository.Insert(article);
        }

        public Article GetArticle(int id)
        {
            return articleRepository.GetById(id);
        }

        #endregion

        #region material

        public int AddMaterial(Material model)
        {
            return materialRepository.Insert(model);
        }

        public void DeleteMaterial(Material model)
        {
            materialRepository.Delete(model);
        }

        public PageData<Material> MaterialPage(PageReq pageReq)
        {
            return materialRepository.MaterialPage(pageReq);
        }

        public void UpdateMaterial(Material model)
        {
            materialRepository.Update(model);
        }

        #endregion

        #region franchisee

        public int AddFranchisee(Franchisee model)
        {
            return franchiseeRepository.Insert(model);
        }

        public void DeleteFranchisee(Franchisee model)
        {
            throw new NotImplementedException();
        }

        public void FranchiseePage(PageReq pageReq)
        {
            franchiseeRepository.FranchiseePage(pageReq);
        }
        public void UpdateFranchisee(Franchisee model)
        {
            franchiseeRepository.Update(model);
        }
        #endregion

        #region product

        public PageData<Product> ProductPage(PageReq pageReq)
        {
            return productRepository.ProductPage(pageReq);
        }

        public void DeleteProduct(Product model)
        {
            productRepository.Delete(model);
        }

        public int AddProduct(Product model)
        {
            return productRepository.Insert(model);
        }

        public void UpdateProduct(Product model)
        {
            productRepository.Update(model);
        }


        public int AddProductCategory(ProductCategory model)
        {
            var id=productRepository.InsertProductCategory(model);

            return id;                
        }

        public void DeleteProductCategory(ProductCategory model)
        {
            productRepository.DeleteProductCategory(model);
        }

        public void UpdateProductCategory(ProductCategory model)
        {
            productRepository.UpdateProductCategory(model);
        }

        public PageData<ProductCategory> ProductCategoryPage(PageReq pageReq)
        {
            return productRepository.ProductCategoryPage(pageReq);
        }

        #endregion

        #region member

        public void DeleteMember(Member member)
        {
            memberRepository.Delete(member);
        }

        public void UpdateMember(Member model)
        {
            memberRepository.Update(model);
        }

        public int AddMember(Member model)
        {
            return memberRepository.Insert(model);
        }

        public PageData<Member> MemberPage(PageReq pageReq)
        {
            return memberRepository.MemberPage(pageReq);
        }


        #endregion

    }
}
