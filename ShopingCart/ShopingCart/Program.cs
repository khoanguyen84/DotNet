using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShopingCart.BAL;
using System;
namespace ShopingCart
{
    class Program
    {
        private static ShoppingService shoppingService = new ShoppingService();
        public static void Main(string[] args)
        {
            //BuildMenu();
            shoppingService.GetReport();
        }

        public static void BuildMenu()
        {
            int selected;
            do
            {
                Console.WriteLine("-----------Shopping Cart----------------");
                Console.WriteLine("1. View list of product");
                Console.WriteLine("2. Add to cart");
                Console.WriteLine("3. Show cart detail");
                Console.WriteLine("4. Remove cart item");
                Console.WriteLine("5. Checkout");
                Console.WriteLine("6. View bill");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choise: ");
                int.TryParse(Console.ReadLine(), out selected);
                while (selected == 0 || selected > (int)Helper.Helper.ActionName.Exit)
                {
                    Console.WriteLine("Invalid number, please try again");
                    Console.Write("Enter your choise: ");
                    int.TryParse(Console.ReadLine(), out selected);
                }
                switch (selected)
                {
                    case (int)Helper.Helper.ActionName.GetProducts:
                        {
                            shoppingService.ShowProduct();
                            break;
                        }
                    case (int)Helper.Helper.ActionName.AddToCart:
                        {
                            shoppingService.AddToCart();
                            break;
                        }
                    case (int)Helper.Helper.ActionName.ShowCartDetail:
                        {
                            shoppingService.ShowCart();
                            break;
                        }
                    case (int)Helper.Helper.ActionName.RemoveCartItem:
                        {
                            shoppingService.RemoveCartItem();
                            break;
                        }
                    case (int)Helper.Helper.ActionName.Checkout:
                        {
                            shoppingService.CheckOut();
                            break;
                        }
                    case (int)Helper.Helper.ActionName.ShowBill:
                        {
                            shoppingService.ShowBill();
                            break;
                        }
                    case (int)Helper.Helper.ActionName.Exit:
                        {
                            Environment.Exit(0);
                            break;
                        }
                }
            }
            while (selected > 0 && selected < (int)Helper.Helper.ActionName.Exit);
        }
    }
    
}