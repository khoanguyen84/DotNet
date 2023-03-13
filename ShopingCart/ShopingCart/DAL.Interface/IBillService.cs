using ShopingCart.Domain;
using ShopingCart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.DAL.Interface
{
    public interface IBillService
    {
        bool CreateBill(List<CartDetail> cartDetails);
        Bill GetBill(int billId);
    }
}
