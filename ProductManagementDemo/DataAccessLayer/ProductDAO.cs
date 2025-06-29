﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        private static List<Product> listProducts;

        static ProductDAO()
        {
            Product chai = new Product(1, "Chai", 3, 12, 18);
            Product chang = new Product(2, "Chang", 1, 23, 19);
            Product aniseed = new Product(3, "Aniseed Syrup", 2, 23, 10);
            listProducts = new List<Product> { chai, chang, aniseed };
        }

        public static List<Product> GetProducts()
        {
            return listProducts;
        }

        

        public static void SaveProduct(Product p)
        {
            listProducts.Add(p);
        }

        public static void UpdateProduct(Product product)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == product.ProductId)
                {
                    p.ProductId = product.ProductId;
                    p.ProductName = product.ProductName;
                    p.CategoryId = product.CategoryId;
                    p.UnitsInStock = product.UnitsInStock;
                    p.UnitPrice = product.UnitPrice;
                }
            }
        }

        public static void DeleteProduct(Product product)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == product.ProductId)
                {
                    listProducts.Remove(p);
                }
            }
        }

        public static Product GetProductById(int id)
        {
            foreach (Product p in listProducts.ToList())
            {
                if (p.ProductId == id)
                {
                    return p;
                }
            }
            return null;
        }
    }
}
