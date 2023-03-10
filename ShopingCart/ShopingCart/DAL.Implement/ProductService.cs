using ShopingCart.AppContext;
using ShopingCart.DAL.Interface;
using ShopingCart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.DAL.Implement
{
    public class ProductService : IProductService
    {
        private ShoppingContext shoppingContext;
        public ProductService() 
        {
            shoppingContext = new ShoppingContext();
        }
        public Product GetProduct(int productId)
        {
            return shoppingContext.Products.FirstOrDefault(p => p.ProductId == productId) ?? new Product();
        }

        public List<Product> GetProducts()
        {
            return shoppingContext.Products.ToList();
        }
    }
}
