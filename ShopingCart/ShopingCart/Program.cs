using ShopingCart.BAL;
using System;
namespace ShopingCart
{
    class Program
    {
        private static ShoppingService shoppingService = new ShoppingService();
        public static void Main(string[] args) 
        {
            //shoppingService.AddToCart();
            //shoppingService.AddToCart();
            //shoppingService.ShowCart();
            //shoppingService.CheckOut();
            //shoppingService.ShowCart();
            shoppingService.ShowBill(1);
        }
    }
}