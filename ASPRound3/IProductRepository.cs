using System;
using System.Collections.Generic;
using ASPRound3.Models;
using Testing.Models;

namespace ASPRound3
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

        // add studded out method to creat view one product at a time
        public Product GetProduct(int id);

        // ability to make updates to that product
        public void UpdateProduct(Product product);

        //give the user the ability to make create new products
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();




    }
}
