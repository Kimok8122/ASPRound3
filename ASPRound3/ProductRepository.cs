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

        // add method to creat view one product at a time
        // We will use the QuerySingle<Product> Dapper method so that we can return a single row 

        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id",
                new { id = id });
        }

    }
}
