﻿using Microsoft.EntityFrameworkCore;
using ProductManage.AppContext;
using ProductManage.DAL.Interface;
using ProductManage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManage.DAL.Implement
{
    public class ProductService : IProductService
    {
        private ProductDbContext productContext;
        public ProductService()
        {
            productContext = new ProductDbContext();
        }

        public bool CreateProduct(Product product)
        {
            try
            {
                productContext.Products.Add(product);
                return productContext.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteProduct(Product product)
        {
            productContext.Products.Remove(product);
            return productContext.SaveChanges() > 0;
        }

        public Product GetProduct(int id)
        {
            return productContext.Products.Include(p => p.Category).FirstOrDefault(p => p.ProductId == id) ?? null;
        }

        public List<Product> GetProducts()
        {
            var product = productContext.Products.ToList();
            return product;
        }

        public bool UpdateProduct(Product newProduct)
        {
            productContext.Products.Update(newProduct);
            return productContext.SaveChanges() > 0; 
        }
    }
}
