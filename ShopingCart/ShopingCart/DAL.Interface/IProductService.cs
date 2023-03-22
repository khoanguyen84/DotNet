using ShopingCart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.DAL.Interface
{
    public interface IProductService
    {
        List<Product> GetProducts();
        Product GetProduct(int productId);
        bool CreateProduct(Product product);
    }
}
