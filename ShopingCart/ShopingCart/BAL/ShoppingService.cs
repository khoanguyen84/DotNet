using ShopingCart.DAL.Implement;
using ShopingCart.Domain;
using ShopingCart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.BAL
{
    public class ShoppingService
    {
        private CartService cartService;
        private ProductService productService;
        private BillService billService;
        public ShoppingService() 
        {
            cartService = new CartService();
            productService = new ProductService();
            billService = new BillService();
        }

        public void ShowProduct()
        {
            List<Product> products = productService.GetProducts();
            Console.WriteLine("#ID\tProductName\t\tPrice");
            foreach (Product product in products) 
            {
                Console.WriteLine($"{product.ProductId}\t{product.ProductName}\t\t{product.Price}");
            }
        }

        public void AddToCart()
        {
            Product product = new Product();
            do
            {
                Console.Write("Enter Product Id:");
                int.TryParse(Console.ReadLine(), out int productId);
                product = productService.GetProduct(productId);
                if (string.IsNullOrEmpty(product.ProductName))
                {
                    Console.WriteLine("Invalid Product Id, please input again!");
                }
            }
            while (string.IsNullOrEmpty(product.ProductName));
            Console.Write("Enter Quantity:");
            int.TryParse(Console.ReadLine(), out int quantity);
            CartDetail cartDetail = new CartDetail()
            {
                ProductId = product.ProductId,
                ProductName = product.ProductName,
                Quantity = quantity,
                Price = product.Price
            };
            cartService.AddToCart(cartDetail);
        }

        public void ShowCart()
        {
            List<CartDetail> cart = cartService.GetCart();
            Console.WriteLine("#ID\tProductName\t\tPrice\t\tQuantity\t\tAmount");
            foreach (CartDetail item in cart)
            {
                Console.WriteLine($"{item.ProductId}\t{item.ProductName}\t\t{item.Price}\t\t{item.Quantity}\t\t{item.Amount}");
            }
        }

        public void CheckOut()
        {
            List<CartDetail> cartDetails = cartService.GetCart();
            billService.CreateBill(cartDetails);
            cartService.ClearCart();
        }

        public void ShowBill(int billId)
        {
            Bill bill = billService.GetBill(billId);
            Console.WriteLine($"Total Amount: {Helper.Helper.CurrencyFormat(bill.TotalAmount)}");
            Console.WriteLine($"Created Date: {bill.CreatedDate.ToString("dd/MM/yyyy")}");

            Console.WriteLine("#ID\tProductName\t\tPrice\t\tQuantity\t\tAmount");
            foreach (BillDetail item in bill.BillDetails)
            {
                Console.WriteLine($"{item.Product.ProductId}" +
                    $"                  \t{item.Product.ProductName}" +
                    $"                  \t\t{Helper.Helper.CurrencyFormat(item.Price)}" +
                    $"                  \t\t{item.Quantity}" +
                    $"                  \t\t{Helper.Helper.CurrencyFormat(item.Amount)}");
            }
        }
    }
}
