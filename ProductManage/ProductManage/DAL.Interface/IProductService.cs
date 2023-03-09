using ProductManage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManage.DAL.Interface
{
    public interface IProductService
    {
        public List<Product> GetProducts();
        public bool CreateProduct(Product product);
        public Product GetProduct(int id);
        public bool DeleteProduct(Product product);
        public bool UpdateProduct(Product newProduct);
    }
}
