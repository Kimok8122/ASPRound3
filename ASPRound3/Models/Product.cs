﻿using System;
namespace ASPRound3.Models
{
    public class Product
    {
        public Product()
        { 
        }

        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }

    }
}
