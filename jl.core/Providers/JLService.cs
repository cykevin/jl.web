﻿using JL.Core.Common;
using JL.Core.Repositories;
using JL.Core.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using JL.Core.Filters;
using JL.Infrastructure;

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
        private readonly IBannerRepository bannerRepository;        

        public JLService(IUserRepository userRepository,
            IArticleRepository articleRepository,
            IProductRepository productRepository,
            IMemberRepository memberRepository,
            IFranchiseeRepository franchiseeRepository,
            IMaterialRepository materialRepository,
            IBannerRepository bannerRepository)
        {
            this.userRepository = userRepository;
            this.articleRepository = articleRepository;
            this.productRepository = productRepository;
            this.memberRepository = memberRepository;
            this.franchiseeRepository = franchiseeRepository;
            this.materialRepository = materialRepository;
            this.bannerRepository = bannerRepository;
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
        
        public PageData<Article> ArticlePage(PageReq<ArticleFilter> pageReq)
        {
            return articleRepository.ArticlePage(pageReq);
        }
        
        public IEnumerable<Article> GetHotestArticle(int top)
        {
            return articleRepository.GetHotestArticle(top);
        }

        public IEnumerable<Article> GetLatestArticle(int top)
        {
            return articleRepository.GetLatestArticle(top);
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

        public PageData<Material> MaterialPage(PageReq<MaterialFilter> pageReq)
        {
            return materialRepository.MaterialPage(pageReq);
        }

        public Material GetMaterial(int id)
        {
            return materialRepository.GetById(id);
        }

        public void IncrementPageViews(int id)
        {
            materialRepository.IncrementPageVies(id);
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

        public PageData<Franchisee> FranchiseePage(PageReq pageReq)
        {
            return franchiseeRepository.FranchiseePage(pageReq);
        }

        public PageData<Franchisee> FranchiseePage(PageReq<FranchiseeFilter> pageReq)
        {
            return franchiseeRepository.FranchiseePage(pageReq);
        }

        public void UpdateFranchisee(Franchisee model)
        {
            franchiseeRepository.Update(model);
        }

        public Franchisee GetFranchisee(int id)
        {
            return franchiseeRepository.GetById(id);
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

        public PageData<Product> ProductPage(PageReq<ProductFilter> pageReq)
        {
            return productRepository.ProductPage(pageReq);
        }

        public Product GetProduct(int id)
        {
            return productRepository.GetById(id);
        }

        public ProductCategory GetProductCategory(int id)
        {
            return productRepository.GetProductCategoryById(id);
        }

        public void ProductToCategory(int productId, IEnumerable<int> categoryIds)
        {
            if (productId > 0 && categoryIds != null && categoryIds.Any())
            {
                productRepository.SetProductToCategory(productId, categoryIds);
            }
        }

        public IEnumerable<ProductCategory> GetProductCategoryList()
        {
            return productRepository.GetProductCategoryList();
        }
        
        public IEnumerable<Product> GetProductsRecommends()
        {
            return productRepository.GetList("where isrecommendasnew=0 ", "*", 8, "order by sortindex desc");
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

        public Member GetMember(int id)
        {
            return memberRepository.GetById(id);
        }


        public PageData<Member> MemberPage(PageReq<MemberFilter> pageReq)
        {
            return memberRepository.MemberPage(pageReq);
        }


        #endregion

        #region banner

        public int AddBanner(Banner banner)
        {
            return bannerRepository.Insert(banner);
        }

        public void UpdateBanner(Banner banner)
        {
            bannerRepository.Update(banner);
        }

        public void DeleteBanner(int id)
        {
            bannerRepository.Delete(id);
        }

        public Banner GetBanner(int id)
        {
            return bannerRepository.GetById(id);
        }

        public PageData<Models.Banner> BannerPage(PageReq pageReq)
        {
            return bannerRepository.BannerPage(pageReq);
        }


        public IEnumerable<Banner> Banners()
        {
            var banners = bannerRepository.GetList();

            return banners.Where(b => b.Status == Consts.BannerStatus_Enable);
        }

        #endregion

    }
}
