using System;
using System.Collections.Generic;
using ASPRound3.Models;

namespace ASPRound3
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

        // add studded out method to creat view one product at a time
        public Product GetProduct(int id);





    }
}
