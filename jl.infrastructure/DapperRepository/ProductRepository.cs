﻿using JL.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JL.Core.Common;
using JL.Core.Models;
using Dapper;

namespace JL.Infrastructure.DapperRepository
{
    public class ProductRepository : IProductRepository
    {
        public PageData<Product> FranchiseePage(PageReq pageReq)
        {
            throw new NotImplementedException();
        }
        
        #region methods from t4

        public void Add(Product model)
        {
            var connection = DbConnectionFactory.CreateConnection();
            connection.Execute(@"Insert into Product(Name,Alias,Description,Picture,RetailPrice,MarketPrice,PageViews,SortIndex,Status)
values (@Name,@Alias,@Description,@Picture,@RetailPrice,@MarketPrice,@PageViews,@SortIndex,@Status)",
                model);
        }

        public Product GetById(int id)
        {
            var query = "select * from Product where AutoId=@id";

            var conn = DbConnectionFactory.CreateConnection();
            return conn.Query<Product>(query, new { id = id }).FirstOrDefault();

        }

        public void Update(Product model)
        {
            var sql = "update Product set Name=@Name,Alias=@Alias,Description=@Description,Picture=@Picture,RetailPrice=@RetailPrice,MarketPrice=@MarketPrice,PageViews=@PageViews,SortIndex=@SortIndex,Status=@Status where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(Product model)
        {
            var sql = "delete from Product where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, model);
        }

        public void Delete(int id)
        {
            var sql = "delete from Product where AutoId=@AutoId";
            var conn = DbConnectionFactory.CreateConnection();
            conn.Execute(sql, new { AutoId = id });
        }

        #endregion
    }
}