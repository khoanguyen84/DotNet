using ProductManage.AppContext;
using ProductManage.DAL.Implement;
using ProductManage.Entities;

namespace ProductManage
{
    class Program
    {
        public static ProductService productService = new ProductService();
        public static StaffService staffService = new StaffService();
        public static void Main(string[] args)
        {
            //Product newProduct = new Product()
            //{
            //    ProductId = 1,
            //    Name = "iPhone 14 Pro Max",
            //    Description = "iPhone 14 Pro Max, Manufactory Thailand",
            //    Price = 40000000,
            //    Rates = ""
            //};
            //UpdateProduct(newProduct);
            //ShowProduct(1);
            ShowStaffs();
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
            if(!Object.Equals(product, null))
            {
                Console.WriteLine("ProductId\t\tProduct Name\t\t\tPrice\t\tCategory");
                Console.WriteLine($"{product.ProductId}\t\t{product.Name}\t\t\t{product.Price}\t\t{product.Category.CategoryName}");
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

        public static void UpdateProduct(Product newProduct)
        {
            Product curProduct = productService.GetProduct(newProduct.ProductId);
            if (!Object.Equals(curProduct, null))
            {
                curProduct.Name = newProduct.Name;
                curProduct.Description = newProduct.Description;
                curProduct.Price = newProduct.Price;
                curProduct.Rates = newProduct.Rates;

                if(productService.UpdateProduct(curProduct))
                {
                    Console.WriteLine("Product has been updated");
                }
            }
            else
            {
                Console.WriteLine("Invalid Product");
            }
        }

        public static void ShowStaffs()
        {
            List<Staff> staffs = staffService.GetStaffs();
            Console.WriteLine("StaffId\t\tFullname\t\tEmail\t\tDoB");
            foreach (Staff staff in staffs)
            {
                Console.WriteLine($"{staff.StaffId}\t\t{staff.Fullname}\t\t{staff.Email}\t\t{staff.DateOfBirth.ToString("MM/dd/yyyy")}");
            }
        }
    }
}
