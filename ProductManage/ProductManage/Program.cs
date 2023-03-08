using ProductManage.DAL.Implement;
using ProductManage.Entities;

namespace ProductManage
{
    class Program
    {
        public static ProductService productService = new ProductService();
        public static void Main(string[] args)
        {
            RemoveProduct(5);
        }

        public static void ShowProduts()
        {
            List<Product> products = new List<Product>();
            products = productService.GetProducts();
            Console.WriteLine("ProductId\t\tProduct Name\t\t\tPrice");
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.ProductId}\t\t{product.Name}\t\t\t{product.Price}");
            }
        }

        public static void ShowProduct(int id)
        {
            Product product = productService.GetProduct(id);
            if(Object.Equals(product, null))
            {
                Console.WriteLine("ProductId\t\tProduct Name\t\t\tPrice");
                Console.WriteLine($"{product.ProductId}\t\t{product.Name}\t\t\t{product.Price}");
            }
            else
            {
                Console.WriteLine("Not Found");
            }    
        }    

        public static bool AddProduct()
        {
            Product product = new Product()
            {
                Name = "Oppo",
                Description = "Korean",
                Price = 7000000,
                Rates = ""
            };
            bool result = productService.CreateProduct(product);
            return result;
        }

        public static void RemoveProduct(int id)
        {
            Product delProduct = productService.GetProduct(id);
            if (Object.Equals(delProduct, null))
            {
                Console.WriteLine("Invalid product");
            }
            else
            {
                if (productService.DeleteProduct(delProduct))
                {
                    Console.WriteLine("Product has been remove success");
                }
                else
                {
                    Console.WriteLine("Can not remove product.");
                }
                
            }
        }
    }
}
