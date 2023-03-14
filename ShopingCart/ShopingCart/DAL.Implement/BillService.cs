using Microsoft.EntityFrameworkCore;
using ShopingCart.AppContext;
using ShopingCart.DAL.Interface;
using ShopingCart.Domain;
using ShopingCart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.DAL.Implement
{
    public class BillService : IBillService
    {
        private ShoppingContext shoppingContext;
        public BillService()
        {
            shoppingContext = new ShoppingContext();
        }
        public bool CreateBill(List<CartDetail> cartDetails)
        {
            try
            {
                int totalAmount = cartDetails.Sum(item => item.Amount);
                Bill bill = new Bill()
                {
                    CreatedDate = DateTime.Now,
                    TotalAmount = totalAmount,
                };
                shoppingContext.Bills.Add(bill);
                shoppingContext.SaveChanges();
                foreach(CartDetail cartDetail in cartDetails) 
                {
                    BillDetail billDetail = new BillDetail()
                    {
                        BillId = bill.BillId,
                        Price = cartDetail.Price,
                        ProductId = cartDetail.ProductId,
                        Quantity = cartDetail.Quantity,
                    };
                    shoppingContext.BillDetails.Add(billDetail);
                    shoppingContext.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false; 
            }
        }

        public Bill GetBill(int billId)
        {
            Bill bill = shoppingContext.Bills.Include(b => b.BillDetails).ThenInclude(bd => bd.Product).FirstOrDefault(b => b.BillId == billId) ?? new Bill();
            return bill;
        }
    }
}
