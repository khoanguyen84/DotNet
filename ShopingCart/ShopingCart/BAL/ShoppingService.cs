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
        private ReportService reportService;
        public ShoppingService() 
        {
            cartService = new CartService();
            productService = new ProductService();
            billService = new BillService();
            reportService = new ReportService();
        }

        public void ShowProduct()
        {
            List<Product> products = productService.GetProducts();
            DataTable(new string[] { "#ID", "ProductName", "Price" }, false);
            foreach (Product product in products) 
            {
                DataTable(new string[] { product.ProductId.ToString(), product.ProductName, product.Price.ToString()}, product == products.Last());
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
            DataTable(new string[] { "#ID", "ProductName", "Price", "Quantity", "Amount" }, false);
            foreach (CartDetail item in cart)
            {
                DataTable(new string[] { item.ProductId.ToString(), item.ProductName, item.Price.ToString(), item.Quantity.ToString(), item.Amount.ToString() }, item == cart.Last());
            }
        }

        public void RemoveCartItem()
        {
            Console.Write("Enter Product Id:");
            int.TryParse(Console.ReadLine(), out int productId);
            if (productId <= 0)
            {
                Console.Write("Invalid ProductId");
                return;
            }
            CartDetail cartDetail = cartService.GetCartItem(productId);
            if (cartDetail.ProductId <= 0)
            {
                Console.Write("ProductId not found");
                return;
            }
            cartService.RemoveCartItem(productId);
            Console.Write($"Product: {cartDetail.ProductName} removed from cart");
        }
        public void CheckOut()
        {
            List<CartDetail> cartDetails = cartService.GetCart();
            billService.CreateBill(cartDetails);
            cartService.ClearCart();
        }

        public void ShowBill()
        {
            Console.Write("Enter Bill Id:");
            int.TryParse(Console.ReadLine(), out int billId);
            if(billId <= 0) {
                Console.Write("Invalid BillId");
                return;
            }
            Bill bill = billService.GetBill(billId);
            if(bill.BillId <= 0)
            {
                Console.Write("BillId not found");
                return;
            }
            Console.WriteLine($"Total Amount: {Helper.Helper.CurrencyFormat(bill.TotalAmount)}");
            Console.WriteLine($"Created Date: {bill.CreatedDate.ToString("dd/MM/yyyy")}");

            DataTable(new string[] { "#ID", "ProductName", "Price", "Quantity", "Amount" }, false);
            foreach (BillDetail item in bill.BillDetails)
            {
                DataTable(new string[] { item.ProductId.ToString(), 
                                            item.Product.ProductName, 
                                            Helper.Helper.CurrencyFormat(item.Price), 
                                            item.Quantity.ToString(), 
                                            Helper.Helper.CurrencyFormat(item.Amount) }, item == bill.BillDetails.Last());
            }
        }

        public void DataTable(string[] columns, bool isLastCol, int width = 100)
        {
            int colWidth = (width - columns.Length) / columns.Length;
            string row = "|";
            Console.WriteLine(new String('-', width));
            foreach (string column in columns)
            {
                row += AlignData(column, colWidth) + "|";
            }
            Console.WriteLine(row);
            if (isLastCol)
            {
                Console.WriteLine(new String('-', width));
            }
        }

        public string AlignData(string text, int colWidth)
        {
            text = text.Length > colWidth ? text.Substring(0, colWidth - 3) + "..." : text;
            if (string.IsNullOrEmpty(text))
            {
                return new String(' ', colWidth);
            }
            else
            {
                return text.PadRight(colWidth - (colWidth - text.Length) / 2).PadLeft(colWidth);
            }
        }

        public void GetReport()
        {
            int min = 40000000;
            int max = 70000000;
            List<Report> reports = reportService.GetReports(min, max);
            DataTable(new string[] { "#BillID", "Total Quantity", "Total Amount", "Created Date"}, false);
            foreach (Report report in reports)
            {
                DataTable(new string[] { report.BillId.ToString(), 
                                        Helper.Helper.CurrencyFormat(report.TotalQuantity),
                                         Helper.Helper.CurrencyFormat(report.TotalAmount),
                                        report.CreatedDate.ToString("MMM-dd-yyyy")}, report == reports.Last());
            }
        }    
    }
}