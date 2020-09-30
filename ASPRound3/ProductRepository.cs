using System;
using System.Collections.Generic;
using System.Data;
using ASPRound3.Models;
using Dapper;

namespace ASPRound3
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }


    }
}
