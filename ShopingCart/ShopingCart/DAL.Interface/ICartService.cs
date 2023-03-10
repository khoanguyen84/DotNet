using ShopingCart.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.DAL.Interface
{
    public interface ICartService
    {
        List<CartDetail> GetCart();
        bool RemoveCartItem(string productName);
        bool AddToCart(CartDetail cartDetail);
        bool UpdateCartItem(string productName, int newQuantity);
        CartDetail GetCartItem(string productName);
    }
}
