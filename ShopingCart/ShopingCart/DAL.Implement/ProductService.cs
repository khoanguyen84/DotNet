using Dapper;
using ShopingCart.AppContext;
using ShopingCart.DAL.Interface;
using ShopingCart.Entities;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.DAL.Implement
{
    public class ProductService : BaseRepository, IProductService
    {
        private ShoppingContext shoppingContext;
        public ProductService() 
        {
            shoppingContext = new ShoppingContext();
        }

        public bool CreateProduct(Product product)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@productName", product.ProductName);
                parameters.Add("@price", product.Price);
                var result = SqlMapper.Execute(
                        cnn: connection,
                        sql: "sp_CreateProduct",
                        param: parameters,
                        commandType: CommandType.StoredProcedure);
                return result  > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
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
