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
        public ShoppingService() 
        {
            cartService = new CartService();
            productService = new ProductService();
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
                    Console.Write("Invalid Product Id:");
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
            Console.WriteLine("#ProductName\t\tPrice\t\tQuantity\t\tAmount");
            foreach (CartDetail item in cart)
            {
                Console.WriteLine($"{item.ProductName}\t\t{item.Price}\t\t{item.Quantity}\t\t{item.Amount}");
            }
        }
    }
}
